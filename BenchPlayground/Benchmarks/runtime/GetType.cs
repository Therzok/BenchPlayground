using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    public class GetType
    {
        [Benchmark]
        public Type GetTypeGlobal()
        {
            return Type.GetType($"{GetType().FullName}, {GetType().Assembly.FullName}");
        }

        [Benchmark(Baseline = true)]
        public Type GetTypeAssembly()
        {
            return GetType().Assembly.GetType(GetType().FullName);
        }
    }
}
