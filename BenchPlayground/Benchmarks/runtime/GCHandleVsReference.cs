using System;
using System.Runtime.InteropServices;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    public class GCHandleVsReference
    {
        const int length = 1_000_000;
        readonly object[] objects = new object[length];
        static object[] staticReference;
        GCHandle[] handles;

        public GCHandleVsReference()
        {
            for (int i = 0; i < length; ++i)
                objects[i] = new object();
        }

        [IterationSetup(Targets = new[] { nameof(ClassBench) })]
        public void ClassSetup()
        {
            staticReference = new object[length];
            Array.Copy(objects, staticReference, length);
        }

        [Benchmark]
        public void ClassBench()
        {
            for (int i = 0; i < 100; ++i)
                _ = new object[length];
        }

        [IterationCleanup(Targets = new[] { nameof(ClassBench) })]
        public void ClassCleanup()
        {
            staticReference = null;
        }

        [IterationSetup(Targets = new[] { nameof(GCHandleBench) })]
        public void GCHandleSetup()
        {
            handles = new GCHandle[length];
            for (int i = 0; i < length; ++i)
                handles[i] = GCHandle.Alloc(objects[i]);
        }

        [Benchmark]
        public void GCHandleBench()
        {
            for (int i = 0; i < 100; ++i)
                _ = new object[length];
        }

        [IterationCleanup(Targets = new[] { nameof(GCHandleBench) })]
        public void GCHandleCleanup()
        {
            foreach (var handle in handles)
                handle.Free();
        }
    }
}
