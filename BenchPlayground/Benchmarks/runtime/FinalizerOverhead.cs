using System;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
	public class FinalizerOverhead
	{
		private const int ITEMS = 100000;

		private static Simple _instance1;
		private static SimpleWithFinalizer _instance2;
		private static SimpleWithDispose instance3;
		private static SimpleWithFinalizerDispose instance4;

		[Benchmark]
		public void AllocateSimple()
		{
			for (int i = 0; i < ITEMS; i++)
			{
				_instance1 = new Simple();
			}
		}

		[Benchmark]
		public void AllocateSimpleWithFinalizer()
		{
			for (int i = 0; i < ITEMS; i++)
			{
				_instance2 = new SimpleWithFinalizer();
			}
		}

		[Benchmark]
		public void AllocateSimpleWithDispose()
		{
			for (int i = 0; i < ITEMS; i++)
			{
				using (instance3 = new SimpleWithDispose())
				{
				}
			}
		}

		[Benchmark]
		public void AllocateSimpleWithFinalizerDispose()
		{
			for (int i = 0; i < ITEMS; i++)
			{
				using (instance4 = new SimpleWithFinalizerDispose())
				{
				}
			}
        }

        class Base { public int X { get; set; } }

        class Simple : Base { }

        class SimpleWithFinalizer { ~SimpleWithFinalizer() { } }

        class SimpleWithDispose : IDisposable { public void Dispose() { } }

        class SimpleWithFinalizerDispose : IDisposable
        {
            public void Dispose() => GC.SuppressFinalize(this);

            ~SimpleWithFinalizerDispose() {}
        }
    }
}
