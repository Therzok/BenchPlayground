using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	public class ArrayVsHashSetStrings
	{
		readonly string[] array = new[] {
			// These need to be sorted
			"BenchPlayground",
			"BenchPlayground.Core",
			"BenchPlayground.Engine",
			"BenchPlayground.Framework",
			"BenchPlayground.Hit",
		};

		readonly HashSet<string> hashset;

		public IEnumerable<string> ParamsSource { get; } = new[] {
			"BenchPlayground.Core", // hit
			"BenchPlayground.PartialMiss", // partial hit, miss
			"DifferentLetter.Miss", // miss
		};

		[ParamsSource(nameof(ParamsSource))]
		public string Value { get; set; }

		public ArrayVsHashSetStrings()
		{
			hashset = new HashSet<string>(array, StringComparer.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool LinqAny()
		{
			return array.Any(x => StringComparer.OrdinalIgnoreCase.Equals(x, Value));
		}

		[Benchmark]
		public bool LinqContains()
		{
			return array.Contains(Value, StringComparer.OrdinalIgnoreCase);
		}

		[Benchmark]
		public bool BinarySearch()
		{
			return Array.BinarySearch(array, Value, StringComparer.OrdinalIgnoreCase) >= 0;
		}

		[Benchmark]
		public bool ArrayLoop()
		{
			foreach (var x in array)
			{
				if (StringComparer.OrdinalIgnoreCase.Equals(x, Value))
					return true;
			}

			return false;
		}

		[Benchmark]
		public bool Set()
		{
			return hashset.Contains(Value);
		}
	}
}
