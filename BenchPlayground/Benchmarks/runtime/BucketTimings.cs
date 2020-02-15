using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
	public class BucketTimings
	{
        static ImmutableArray<int> GenerateBuckets(int maximumValue)
        {
			return ImmutableArray.CreateRange(PowerOfTwoSequence(8, maximumValue));

            static IEnumerable<int> PowerOfTwoSequence(int start, int maximumValue)
            {
				for (int i = start; i < maximumValue; i *= 2)
					yield return i;
            }
        }

		ImmutableArray<int> BucketLimits;
		TimeSpan[] ascending, descending, random;
        
        [GlobalSetup]
        public void TestData()
		{
			BucketLimits = GenerateBuckets(MaximumValue);

			var currentValues = Enumerable.Range(0, MaximumValue * 2)
				.Select(x => new TimeSpan(x * TimeSpan.TicksPerMillisecond));

			ascending = currentValues.ToArray();
			descending = currentValues.Reverse().ToArray();
			random = currentValues.ToList().Shuffle().ToArray();
        }

        [Params(8, 32, 128, 512, 2048)]
        public int MaximumValue { get; set; }

        [Benchmark(Baseline = true)]
        public Implementation Add()
        {
			var bucket = new Implementation(BucketLimits);
			foreach (var value in ascending)
				bucket.Add(value);
			return bucket;
        }

		[Benchmark]
		public Implementation AddDescending()
		{
			var bucket = new Implementation(BucketLimits);
			foreach (var value in descending)
				bucket.Add(value);
			return bucket;
		}

		[Benchmark]
		public Implementation AddRandom()
		{
			var bucket = new Implementation(BucketLimits);
			foreach (var value in random)
				bucket.Add(value);
			return bucket;
		}

		[Benchmark]
		public Implementation AddLog()
		{
			var bucket = new Implementation(BucketLimits);
			foreach (var value in ascending)
				bucket.AddLog(value);
			return bucket;
		}

		[Benchmark]
		public Implementation AddLogDescending()
		{
			var bucket = new Implementation(BucketLimits);
			foreach (var value in descending)
				bucket.AddLog(value);
			return bucket;
		}

		[Benchmark]
		public Implementation AddLogRandom()
		{
			var bucket = new Implementation(BucketLimits);
			foreach (var value in random)
				bucket.AddLog(value);
			return bucket;
		}

		public class Implementation
		{
			readonly int[] buckets;
			readonly ImmutableArray<int> bucketUpperLimit;

			/// <summary>
			/// Initializes a new instance of the <see cref="T:MonoDevelop.Core.Instrumentation.BucketTimings"/> class,
			/// taking into account the upper limit bucket counts given.
			/// </summary>
			/// <param name="bucketUpperLimit">A sorted array of values to use when trying to bucket.</param>
			public Implementation(ImmutableArray<int> bucketUpperLimit)
			{
				this.bucketUpperLimit = bucketUpperLimit;

				// One more than bucketUpperLimit because the last bucket is everything else.
				// This number is the max time a keystroke can take to be placed into this bucket
				buckets = new int[bucketUpperLimit.Length + 1];
			}

			int CalculateBucket(TimeSpan duration)
			{
				long ms = duration.Ticks / TimeSpan.TicksPerMillisecond;
				for (var bucket = 0; bucket < bucketUpperLimit.Length; bucket++)
				{
					if (ms <= bucketUpperLimit[bucket])
					{
						return bucket;
					}
				}

				return buckets.Length - 1;
			}

			public void Add(TimeSpan duration)
			{
				var bucketNumber = CalculateBucket(duration);
				buckets[bucketNumber]++;
			}

#if NETFRAMEWORK
			public void AddLog(TimeSpan duration)
			{
				var bucketNumber = Math.Log(duration.Ticks / TimeSpan.TicksPerMillisecond, 2) - 3;
				var upperLimit = bucketUpperLimit.Length - 1;
				var bucketNumberNormalized = (bucketNumber < 0) ? 0 : (bucketNumber > upperLimit) ? upperLimit : bucketNumber;
				buckets[(int)bucketNumberNormalized]++;
			}
#else
			public void AddLog(TimeSpan duration)
			{
				var bucketNumber = Math.Log2(duration.TotalMilliseconds) - 3;
				var upperLimit = bucketUpperLimit.Length - 1;
				var bucketNumberNormalized = Math.Clamp(bucketNumber, 0, upperLimit);
				buckets[(int)bucketNumberNormalized]++;
			}
#endif

			public void Compare(Implementation other)
			{
				for (int i = 0; i < buckets.Length; ++i)
				{
					if (buckets[i] != other.buckets[i])
						throw new Exception();
				}
			}
		}
	}
}
