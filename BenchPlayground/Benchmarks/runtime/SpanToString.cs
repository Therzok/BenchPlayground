using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks.runtime
{
    [MemoryDiagnoser]
    public class SpanToString
    {
        public IEnumerable<string> Items { get; } = new List<string>
        {
            new string ('a', 1),
            new string ('a', 32),
            new string ('a', 128),
            new string ('a', 1024 * 16),
            new string ('a', 1024 * 128),
        };

        [Benchmark]
        [ArgumentsSource(nameof(Items))]
        public string Substring(string input)
        {
            return input.Substring(1);
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Items))]
        public string SliceToString(string input)
        {
            return input.AsSpan(1).ToString();
        }
    }
}
