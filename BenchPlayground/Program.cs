using BenchmarkDotNet.Running;

namespace BenchPlayground
{
	class Program
	{
		static void Main(string[] args)
			=> BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
	}
}
