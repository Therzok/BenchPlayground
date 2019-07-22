using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	public class OverheadOfDictionary
	{
		public enum EventDataKind
		{
			Created,
			Changed,
			Copied,
			Moved,
			Removed,
			Renamed,
		}

		readonly Dictionary<EventDataKind, TimeSpan> timingsDict = new Dictionary<EventDataKind, TimeSpan>();
		readonly TimeSpan[] timingsArray = new TimeSpan[6];

		public (EventDataKind, TimeSpan)[] Values { get; }

		public OverheadOfDictionary()
		{
			var list = new List<(EventDataKind, TimeSpan)>();

			var sizes = new[]
			{
				// In reality, most of the events are changed, so weight them for closer to reality
				// random access
				(EventDataKind.Created, 1500),
				(EventDataKind.Changed, 6001),
				(EventDataKind.Copied, 333),
				(EventDataKind.Moved, 333),
				(EventDataKind.Removed, 1500),
				(EventDataKind.Renamed, 333),
			};

			foreach (var (kind, count) in sizes)
			{
				TimeSpan value = TimeSpan.Zero;
				for (int i = 0; i < count; ++i)
				{
					list.Add((kind, TimeSpan.FromMilliseconds(i)));
				}
			}

			Values = list.Shuffle().ToArray();
		}

		[Benchmark]
		public void BenchDict()
		{
			for (int i = 0; i < Values.Length; ++i)
			{
				var (kind, time) = Values[i];
				timingsDict[kind] = timingsDict.TryGetValue(kind, out var previous)
					? previous + time
					: time;
			}
		}

		[Benchmark]
		public void BenchArray()
		{
			for (int i = 0; i < Values.Length; ++i)
			{
				var (kind, time) = Values[i];
				timingsArray[(int)kind] += time;
			}
		}
	}
}
