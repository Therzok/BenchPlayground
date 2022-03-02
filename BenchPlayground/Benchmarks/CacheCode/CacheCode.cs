using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    public class CacheCodeBench
    {
        [ParamsSource(nameof(GetComparers))]
        public StringComparison ComparisonType { get; set; }

        public StringComparison[] GetComparers => new[] {
            StringComparison.Ordinal,
            StringComparison.OrdinalIgnoreCase,
            StringComparison.CurrentCulture,
        };

        public IEnumerable<string> Paths { get; set; } = new[] {
            "/Users/therzok/Work/BenchPlayground",
            "/Applications/Visual Studio.app",
            "/Users/therzok/Work/md/vsmac-copy/main/src/addins/Microsoft.VisualStudioMac.AddinMaker/Microsoft.VisualStudioMac.AddinMaker/NodeBuilders",
            "/",
        };

        public IEnumerable<object> CacheCodePaths() => Paths.Select(x => (object)x.CacheCode(comparer));

        StringComparer comparer;

        [GlobalSetup]
        public void Setup()
        {
            comparer = StringComparer.FromComparison(ComparisonType);
        }

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(Paths))]
        public int GetHashCode(string path)
        {
            return comparer.GetHashCode(path);
        }

        [Benchmark]
        [ArgumentsSource(nameof(CacheCodePaths))]
        public int GetCacheCode(CacheCode<string> path)
        {
            return path.GetHashCode();
        }

        [Benchmark]
        [ArgumentsSource(nameof(Paths))]
        public CacheCode<string> MakeCacheCode(string path)
        {
            return new CacheCode<string>(path, comparer);
        }
    }
}
