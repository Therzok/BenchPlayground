using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	[GenericTypeArguments(typeof(int))]
	[GenericTypeArguments(typeof(object))]
	public class ListVsHashSetIterative<T> where T : new()
	{
		[Params(1, 16, 512)]
		public int Count { get; set; }

		[Benchmark]
		public List<(int, T)> List()
		{
			var list = new List<(int, T)>();
			for (int i = 0; i < Count; ++i)
			{
				var item = (i, new T());
				if (!list.Contains(item))
					list.Add(item);
			}

			return list;
		}

		[Benchmark]
		public HashSet<(int, T)> Set()
		{
			var set = new HashSet<(int, T)>();
			for (int i = 0; i < Count; ++i)
			{
				var item = (i, new T());
				set.Add(item);
			}

			return set;
		}
	}
}
