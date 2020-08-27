using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks.runtime
{
    [MemoryDiagnoser]
    public class SpanToString
    {
        const string input = "aaaa";

        [Params(0, 1)]
        public int Offset { get; set; }

        [Benchmark(Baseline = true)]
        public string Substring()
        {
            return input.Substring(Offset);
        }

        [Benchmark]
        public string SliceToString()
        {
            return input.AsSpan(Offset).ToString();
        }

        [Benchmark]
        public string SliceToStringWithOriginal()
        {
            var span = input.AsSpan(Offset);
            return span.Length == input.Length ? input : span.ToString();
        }
    }
}
