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
    [CategoriesColumn]
    [GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory, BenchmarkLogicalGroupRule.ByMethod)]
    public class FastLinqConcat
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

            public static TestData Array0 => new TestData(new object[0]);
            public static TestData Array1 => new TestData (new object[] { 1 });
            public static TestData Enum0 => new TestData(Enumerable.Empty<object>());
            public static TestData Enum1 => new TestData(Enumerable.Repeat(new object(), 1));
        }

        private readonly Consumer consumer = new Consumer();

        public static IEnumerable<TestData> PossibleValues()
        {
            yield return TestData.Array0;
            yield return TestData.Array1;
            yield return TestData.Enum0;
            yield return TestData.Enum1;
        }

        [ParamsSource(nameof(PossibleValues))]
        public TestData A { get; set; }

        [ParamsSource(nameof(PossibleValues))]
        public TestData B { get; set; }

        const int loops = 100;

        static IEnumerable<object> DoConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = a.Concat(b);
            return a;
        }

        [BenchmarkCategory("Create"), Benchmark(Baseline = true)]
        public object Concat() => DoConcat(A.Value, B.Value);

        [BenchmarkCategory("Consume"), Benchmark(Baseline = true)]
        public void ConcatConsume() => DoConcat(A.Value, B.Value).Consume(consumer);

        static IEnumerable<object> DoFastConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = FastConcat(a, b);
            return a;
        }

        [BenchmarkCategory("Create"), Benchmark]
        public object FConcat() => DoFastConcat(A.Value, B.Value);

        [BenchmarkCategory("Consume"), Benchmark]
        public void FConcatConsume() => DoFastConcat(A.Value, B.Value).Consume(consumer);

        static IEnumerable<object> DoPartConcat(IEnumerable<object> a, IEnumerable<object> b)
        {
            for (int i = 0; i < loops; ++i)
                a = FastConcatPartition(a, b);
            return a;
        }

        [BenchmarkCategory("Create"), Benchmark]
        public object FPartConcat() => DoPartConcat(A.Value, B.Value);

        [BenchmarkCategory("Consume"), Benchmark]
        public void FPartConcatConsume() => DoPartConcat(A.Value, B.Value).Consume(consumer);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        static bool IsEmpty<T>(IEnumerable<T> source)
            => source == Enumerable.Empty<T>() || (source is T[] array && array.Length == 0);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> FastConcatPartition<T> (IEnumerable<T> first, IEnumerable<T> second)
        {
            if (IsEmpty(second))
            {
                return IsEmpty(first) ? Enumerable.Empty<T>() : first;
            }
            return IsEmpty(first) ? second : first.Concat(second);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static IEnumerable<T> FastConcat<T>(IEnumerable<T> first, IEnumerable<T> second)
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
    }
}
