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
