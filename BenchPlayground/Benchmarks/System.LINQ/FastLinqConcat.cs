using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

namespace BenchPlayground.Benchmarks
{
	[MemoryDiagnoser]
	public class FastLinqConcat
	{
		private readonly Consumer consumer = new Consumer();

		public class TestData
		{
			public IEnumerable<object> Value { get; }
			public TestData(IEnumerable<object> value)
			{
				Value = value;
			}

			public override string ToString()
			{
				if (Value.Any())
					return "NonEmpty";
				return "Empty";
			}
		}

		public IEnumerable<TestData> DataSource()
		{
			yield return new TestData(Enumerable.Repeat(new object(), 1));
			yield return new TestData(Enumerable.Empty<object>());
		}

		[ParamsSource(nameof(DataSource))]
		public TestData First { get; set; }

		[ParamsSource(nameof(DataSource))]
		public TestData Second { get; set; }

		[Params(1, 4, 16, 64)]
		public int Times { get; set; }

		[Benchmark(Baseline = true)]
		public void Concat()
		{
			var value = First.Value;
			var toConcat = Second.Value;

			for (int i = 0; i < Times; ++i)
			{
				value = value.Concat(toConcat);
			}

			consumer.Consume(value);
		}

		[Benchmark]
		public void FastConcat()
		{
			var value = First.Value;
			var toConcat = Second.Value;

			for (int i = 0; i < Times; ++i)
			{
				value = FastConcat(value, toConcat);
			}

			consumer.Consume(value);
		}

		public static IEnumerable<T> FastConcat<T>(IEnumerable<T> first, IEnumerable<T> second)
		{
			if (first == Enumerable.Empty<T>())
				return second;
			if (second == Enumerable.Empty<T>())
				return first;
			return first.Concat(second);
		}
	}
}
