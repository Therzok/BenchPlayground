using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
	[GenericTypeArguments(typeof(int))]
	[GenericTypeArguments(typeof(object))]
	public class ArrayCopy<T> where T:new()
	{
		[Params(8, 32, 128, 512, 2048, 8196, 32784)]
		public int Count { get; set; }

		T[] src;

        [GlobalSetup]
        public void Setup()
        {
			src = new T[Count];
            for (int i = 0; i < src.Length; ++i)
            {
				src[i] = new T();
            }
        }

		[Benchmark(Baseline = true)]
		public T[] Loop()
		{
            var result = new T[Count];
            for (int i = 0; i < result.Length; ++i)
            {
                result[i] = src[i];
            }

            return result;
		}

        [Benchmark]
        public T[] Copy3Arg()
        {
            var result = new T[Count];
            Array.Copy(src, result, src.Length);
            return result;
        }

        [Benchmark]
        public T[] Copy5Arg()
        {
            var result = new T[Count];
            Array.Copy(src, 0, result, 0, src.Length);
            return result;
        }
	}
}
