# Mono

``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.1 (19B88) [Darwin 19.0.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.8.0.73 (2019-10/77147e75266 Tue), X64
  Job-LYJIRV : Mono 6.8.0.73 (2019-10/77147e75266 Tue), X64

InvocationCount=1  UnrollFactor=1

```
|        Method |     Mean |    Error |   StdDev |   Median |     Gen 0 |     Gen 1 |     Gen 2 | Allocated |
|-------------- |---------:|---------:|---------:|---------:|----------:|----------:|----------:|----------:|
|    ClassBench | 14.82 ms | 0.300 ms | 0.870 ms | 14.34 ms | 1000.0000 | 1000.0000 | 1000.0000 |         - |
| GCHandleBench | 40.66 ms | 0.422 ms | 0.395 ms | 40.66 ms | 1000.0000 | 1000.0000 | 1000.0000 |         - |

# netcoreapp3.0

``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.1 (19B88) [Darwin 19.0.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.100
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  Job-QNNNKM : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT

InvocationCount=1  UnrollFactor=1

```
|        Method |     Mean |    Error |    StdDev |      Gen 0 |      Gen 1 |      Gen 2 | Allocated |
|-------------- |---------:|---------:|----------:|-----------:|-----------:|-----------:|----------:|
|    ClassBench | 336.5 ms |  2.94 ms |   2.75 ms | 35000.0000 | 35000.0000 | 30000.0000 | 762.94 MB |
| GCHandleBench | 595.3 ms | 40.69 ms | 119.99 ms | 49000.0000 | 28000.0000 | 23000.0000 | 762.94 MB |
