using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    public class StringComparisonBench
    {
        readonly string sourceString = new string('a', 2000);

        public IEnumerable<string> ComparisonStringSource => new[]
        {
            new string('a', 1),
            new string('a', 200),
            new string('a', 1000),
            new string('a', 2000),
            new string('a', 4000),
        };

        [ParamsSource(nameof(ComparisonStringSource))]
        public string ComparisonString { get; set; }

        [ParamsAllValues]
        public StringComparison Comparison { get; set; }

        [Benchmark(Baseline = true)]
        public bool Bench()
        {
            return sourceString.Equals(ComparisonString, Comparison);
        }
    }
}
