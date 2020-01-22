using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	public class ImmutableHashSetBuilderRemove
	{
		const int count = 10000;
		readonly object[] objects;
		readonly ImmutableHashSet<object> hashset;

		[ParamsSource(nameof(ValuesToRemove))]
		public ObjectsToRemove ToRemove;

		public IEnumerable<ObjectsToRemove> ValuesToRemove => new[] {
            new ObjectsToRemove { Objects = ImmutableHashSet<object>.Empty },
			new ObjectsToRemove { Objects = ImmutableHashSet.CreateRange(objects.Take(count / 2)) },
			new ObjectsToRemove { Objects = ImmutableHashSet.CreateRange(objects), },
        };

        public ImmutableHashSetBuilderRemove()
        {
			objects = new object[count];
            for (int i = 0; i < objects.Length; ++i)
            {
				objects[i] = new object();
            }

			hashset = ImmutableHashSet.Create(objects);
        }

		[Benchmark(Baseline = true)]
		public ImmutableHashSet<object> Remove()
		{
			var builder = hashset.ToBuilder();
            foreach (var obj in ToRemove.Objects) {
				builder.Remove(obj);
            }

			return builder.ToImmutable();
		}

		[Benchmark]
		public ImmutableHashSet<object> ExceptWith()
		{
			var builder = hashset.ToBuilder();
			builder.ExceptWith(ToRemove.Objects);

			return builder.ToImmutable();
		}

		public class ObjectsToRemove
		{
			public ImmutableHashSet<object> Objects;

			public override string ToString() => $"Removed {Objects.Count}";
		}
	}
}
