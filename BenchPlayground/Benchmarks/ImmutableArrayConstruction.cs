using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	public class ImmutableArrayConstruction
	{
		const int count = 10000;

		[Benchmark]
		[Arguments(0)]
		[Arguments(count)]
		public ImmutableArray<int> List(int initialCapacity)
		{
			var list = new List<int>(initialCapacity);
			for (int i = 0; i < count; ++i)
				list.Add(i);

			return list.ToImmutableArray();
		}

		[Benchmark]
		[Arguments(0)]
		[Arguments(8)] // default
		[Arguments(count)]
		public ImmutableArray<int> ArrayBuilderToImmutable(int initialCapacity)
		{
			var list = ImmutableArray.CreateBuilder<int>(initialCapacity);
			for (int i = 0; i < count; ++i)
				list.Add(i);

			return list.ToImmutable();
		}

		[Benchmark]
		[Arguments(0)]
		[Arguments(8)] // default
		[Arguments(count)]
		public ImmutableArray<int> ArrayBuilderMaybeToImmutable(int initialCapacity)
		{
			var list = ImmutableArray.CreateBuilder<int>(initialCapacity);
			for (int i = 0; i < count; ++i)
				list.Add(i);

			return list.Capacity == list.Count ? list.MoveToImmutable() : list.ToImmutable();
		}
	}
}
