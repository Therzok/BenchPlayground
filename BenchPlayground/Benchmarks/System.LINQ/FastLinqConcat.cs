using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Engines;

namespace BenchPlayground.Benchmarks
{
    [MemoryDiagnoser]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByMethod)]
    public abstract class BaseLinqConcat
    {
        public class TestData
        {
            public IEnumerable<object> Value { get; }
            readonly string displayString;
            public TestData(IEnumerable<object> value, [CallerMemberName] string label = null)
            {
                Value = value;
                displayString = label;
            }

            public override string ToString() => displayString;

            public static TestData A0 => new TestData(new object[0]);
            public static TestData A1 => new TestData(new object[] { 1 });
            public static TestData E0 => new TestData(Enumerable.Empty<object>());
            public static TestData E1 => new TestData(Enumerable.Repeat(new object(), 1));
        }

        public static IEnumerable<TestData> AValues()
        {
            yield return TestData.E0;
            yield return TestData.A1;
        }

        public static IEnumerable<TestData> BValues()
        {
            yield return TestData.A0;
            yield return TestData.A1;
            yield return TestData.E0;
            yield return TestData.E1;
        }

        [ParamsSource(nameof(AValues))]
        public TestData A { get; set; }

        [ParamsSource(nameof(BValues))]
        public TestData B { get; set; }

        const int loops = 10;

        protected static IEnumerable<object> LinqConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = a.Concat(b);
            return a;
        }

        protected static IEnumerable<object> FastConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = Concat(a, b);
            return a;
        }

        protected static IEnumerable<object> FastPartConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = ConcatPartition(a, b);
            return a;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static IEnumerable<T> ConcatPartition<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            if (IsEmpty(second))
            {
                return IsEmpty(first) ? Enumerable.Empty<T>() : first;
            }
            return IsEmpty(first) ? second : first.Concat(second);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static IEnumerable<T> Concat<T>(IEnumerable<T> first, IEnumerable<T> second)
        {
            if (IsEmpty(second))
            {
                return first;
            }

            if (IsEmpty(first))
            {
                return second;
            }
            return first.Concat(second);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool IsEmpty<T>(IEnumerable<T> source) => source == Enumerable.Empty<T>() || (source is T[] array && array.Length == 0);
    }

    public class FastLinqConsume : BaseLinqConcat
    {
        private readonly Consumer consumer = new Consumer();

        IEnumerable<object> linqConcat;
        IEnumerable<object> fastConcat;
        IEnumerable<object> fastPartConcat;

        [GlobalSetup]
        public void GlobalSetup()
        {
            linqConcat = LinqConcat(A.Value, B.Value);
            fastConcat = FastConcat(A.Value, B.Value);
            fastPartConcat = FastPartConcat(A.Value, B.Value);
        }

        [Benchmark(Baseline = true)]
        public void Concat() => linqConcat.Consume(consumer);

        [Benchmark]
        public void FConcat() => fastConcat.Consume(consumer);

        [Benchmark]
        public void FPartConcat() => fastPartConcat.Consume(consumer);
    }

    public class FastLinqConcat : BaseLinqConcat
    {
        [Benchmark(Baseline = true)]
        public object Concat() => LinqConcat(A.Value, B.Value);
 
        [Benchmark]
        public object FConcat() => FastConcat(A.Value, B.Value);

        [Benchmark]
        public object FPartConcat() => FastPartConcat(A.Value, B.Value);
    }
}
