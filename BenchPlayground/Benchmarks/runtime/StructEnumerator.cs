using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    public class StructEnumerator
    {
        [Params(4, 128, 2048)]
        public int N { get; set; }

        readonly List<int> data;
        readonly CollectionBox box;
        readonly CollectionUnderlying underlying;
        readonly CollectionWrap wrap;
        readonly CollectionWrapNoInterface wrapNoInterface;

        public StructEnumerator()
        {
            data = new List<int>(Enumerable.Range(0, N));
            box = new CollectionBox(data);
            underlying = new CollectionUnderlying(data);
            wrap = new CollectionWrap(data);
            wrapNoInterface = new CollectionWrapNoInterface(data);
        }

        [Benchmark(Baseline = true)]
        public int ForEachList()
        {
            int sum = 0;
            foreach (var value in data)
                sum += value;
            return sum;
        }

        [Benchmark]
        public int ForEachBox()
        {
            int sum = 0;
            foreach (var value in box)
                sum += value;
            return sum;
        }

        [Benchmark]
        public int ForEachUnderlying()
        {
            int sum = 0;
            foreach (var value in underlying)
                sum += value;
            return sum;
        }

        [Benchmark]
        public int ForEachWrap()
        {
            int sum = 0;
            foreach (var value in wrap)
                sum += value;
            return sum;
        }

        [Benchmark]
        public int ForEachWrapNoInterface()
        {
            int sum = 0;
            foreach (var value in wrapNoInterface)
                sum += value;
            return sum;
        }

        sealed class CollectionBox : IEnumerable<int>
        {
            readonly List<int> list;

            public CollectionBox(List<int> list)
            {
                this.list = list;
            }

            // This one gets boxed
            public IEnumerator<int> GetEnumerator() => list.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        sealed class CollectionUnderlying : IEnumerable<int>
        {
            readonly List<int> list;

            public CollectionUnderlying(List<int> list)
            {
                this.list = list;
            }

            // This one just returns the list implementation
            public List<int>.Enumerator GetEnumerator() => list.GetEnumerator();
            IEnumerator<int> IEnumerable<int>.GetEnumerator() => GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        sealed class CollectionWrap : IEnumerable<int>
        {
            readonly List<int> list;

            public CollectionWrap(List<int> list)
            {
                this.list = list;
            }

            // We create a full blown IEnumerator<int> that forwards
            public Enumerator GetEnumerator() => new Enumerator(list);
            IEnumerator<int> IEnumerable<int>.GetEnumerator() => GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            public struct Enumerator : IEnumerator<int>, IEnumerator, IDisposable
            {
                List<int>.Enumerator wrapped;

                public Enumerator(List<int> list)
                {
                    wrapped = list.GetEnumerator();
                }

                public int Current => wrapped.Current;

                object IEnumerator.Current => Current;

                public void Dispose() => wrapped.Dispose();

                public bool MoveNext() => wrapped.MoveNext();

                public void Reset() => ((IEnumerator)wrapped).Reset();
            }
        }

        sealed class CollectionWrapNoInterface : IEnumerable<int>
        {
            readonly List<int> list;

            public CollectionWrapNoInterface(List<int> list)
            {
                this.list = list;
            }

            // Create a slim enumerator and use underlying for interface implementation.
            public Enumerator GetEnumerator() => new Enumerator(list);
            IEnumerator<int> IEnumerable<int>.GetEnumerator() => list.GetEnumerator();
            IEnumerator IEnumerable.GetEnumerator() => list.GetEnumerator();

            public struct Enumerator
            {
                List<int>.Enumerator wrapped;

                public Enumerator(List<int> list)
                {
                    wrapped = list.GetEnumerator();
                }

                public int Current => wrapped.Current;

                public bool MoveNext() => wrapped.MoveNext();
            }
        }
    }
}
