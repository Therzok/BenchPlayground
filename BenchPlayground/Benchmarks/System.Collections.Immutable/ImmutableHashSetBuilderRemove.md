``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.2 (19C57) [Darwin 19.2.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|     Method |      ToRemove |           Mean |        Error |       StdDev | Ratio | RatioSD |    Gen 0 |   Gen 1 | Gen 2 | Allocated |
|----------- |-------------- |---------------:|-------------:|-------------:|------:|--------:|---------:|--------:|------:|----------:|
|     Remove |     Removed 0 |       113.1 ns |      0.54 ns |      0.50 ns |  1.00 |    0.00 |   0.0178 |       - |     - |      56 B |
| ExceptWith |     Removed 0 |       315.9 ns |      1.59 ns |      1.49 ns |  2.79 |    0.02 |   0.0176 |       - |     - |      56 B |
|            |               |                |              |              |       |         |          |         |       |           |
|     Remove | Removed 10000 | 4,991,465.5 ns | 34,796.92 ns | 30,846.57 ns |  1.00 |    0.00 | 109.3750 |       - |     - |  356477 B |
| ExceptWith | Removed 10000 | 4,552,819.0 ns | 37,988.45 ns | 35,534.42 ns |  0.91 |    0.01 | 109.3750 |       - |     - |  356473 B |
|            |               |                |              |              |       |         |          |         |       |           |
|     Remove |  Removed 5000 | 3,062,720.2 ns | 16,970.86 ns | 15,044.22 ns |  1.00 |    0.00 |  89.8438 | 35.1563 |     - |  442115 B |
| ExceptWith |  Removed 5000 | 2,856,912.5 ns | 18,095.71 ns | 16,926.74 ns |  0.93 |    0.01 | 101.5625 | 42.9688 |     - |  442115 B |
