using System;
using System.Collections.Generic;
using System.IO;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Diagnosers;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    [EventPipeProfiler(EventPipeProfile.Jit | EventPipeProfile.CpuSampling | EventPipeProfile.GcCollect)]
    public class EnumerateLinesVsStreamReader
    {
        const string input = @"[Core] Fix MSBuild builder in build mode for temporary build session
    A temporary build session was putting the MSBuild builder into
    build mode. When the builder was then used for building a project
    it would fail. The IDE would show an error:
    Build failed. See the build log for details.
    The MSBuild builder log would show the error:";

        [Benchmark(Baseline = true)]
        public string Stream()
        {
            using (var sr = new StringReader(input))
            {
                var line = sr.ReadLine()?.Trim();
                if (!string.IsNullOrEmpty(line))
                {
                    return line;
                }
            }
            return "";
        }

        [Benchmark]
        public string Span()
        {
            foreach (ReadOnlySpan<char> lineSpan in input.AsSpan().EnumerateLines())
            {
                var line = lineSpan.Trim();
                if (!line.IsEmpty)
                {
                    return line.ToString();
                }
            }
            return "";
        }
    }
}
