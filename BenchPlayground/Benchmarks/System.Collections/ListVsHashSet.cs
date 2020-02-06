using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	[GenericTypeArguments(typeof(int))]
	[GenericTypeArguments(typeof(object))]
	public class ListVsHashSet<T> where T : new()
	{
		readonly List<(int, T)> list = new List<(int, T)>();
		readonly HashSet<(int, T)> set = new HashSet<(int, T)>();

		readonly List<(int, T)> toFind = new List<(int, T)>();

		[Params(1, 16, 512)]
		public int Count { get; set; }

		public ListVsHashSet()
		{
			for (int i = 0; i < Count; ++i) {
				var item = (i, new T());
				list.Add(item);
				set.Add(item);

				if (i == 0 || i == Count / 2 || i == Count - 1)
					toFind.Add(item);
			}

			toFind.Add((-1, new T()));
		}

		[Benchmark]
		public List<(int, T)> List()
		{
			foreach (var item in toFind)
			{
				if (!list.Contains(item))
					list.Add(item);
			}

			return list;
		}

		[Benchmark]
		public HashSet<(int, T)> Set()
		{
			foreach (var item in toFind)
			{
				set.Add(item);
			}

			return set;
		}
	}
}
