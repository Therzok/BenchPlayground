using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground.Benchmarks.System.Text
{
    public class StringBuilderAppendFormat
    {
        [ParamsSource(nameof(Values))]
        public byte[] Data { get; set; }

        public IEnumerable<byte[]> Values { get; } = new[]
        {
            Enumerable.Range(0, 16).Select(x => (byte)x).ToArray(),
            Enumerable.Range(0, 128).Select(x => (byte)x).ToArray(),
            Enumerable.Range(0, 256).Select(x => (byte)x).ToArray(),
        };

        [Benchmark]
        public string AppendFormat()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Data.Length; i++)
                sb.AppendFormat("{0:X2}", Data[i]);
            return sb.ToString();
        }

        [Benchmark(Baseline = true)]
        public string Append()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Data.Length; i++)
                sb.Append(Data[i].ToString("X2"));
            return sb.ToString();
        }

        [Benchmark]
        public string AppendInterpolated()
        {
            var sb = new StringBuilder();
            for (int i = 0; i < Data.Length; i++)
                sb.Append($"{Data[i]:X2}");
            return sb.ToString();
        }
    }
}
