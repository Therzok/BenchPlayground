``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.6 (19G2021) [Darwin 19.6.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|                 Method |    N |      Mean |     Error |    StdDev |    Median | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------------------- |----- |----------:|----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|            ForEachList |    4 |  3.434 ns | 0.0158 ns | 0.0148 ns |  3.429 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|             ForEachBox |    4 | 15.539 ns | 0.1223 ns | 0.1144 ns | 15.503 ns |  4.53 |    0.04 | 0.0127 |     - |     - |      40 B |
|      ForEachUnderlying |    4 |  3.872 ns | 0.1060 ns | 0.1857 ns |  4.020 ns |  1.13 |    0.05 |      - |     - |     - |         - |
|            ForEachWrap |    4 | 15.104 ns | 0.0383 ns | 0.0358 ns | 15.090 ns |  4.40 |    0.02 |      - |     - |     - |         - |
| ForEachWrapNoInterface |    4 | 15.119 ns | 0.0379 ns | 0.0354 ns | 15.114 ns |  4.40 |    0.02 |      - |     - |     - |         - |
|                        |      |           |           |           |           |       |         |        |       |       |           |
|            ForEachList |  128 |  3.720 ns | 0.3455 ns | 0.5064 ns |  3.437 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|             ForEachBox |  128 | 15.984 ns | 0.0907 ns | 0.0804 ns | 15.981 ns |  4.07 |    0.62 | 0.0127 |     - |     - |      40 B |
|      ForEachUnderlying |  128 |  3.643 ns | 0.0136 ns | 0.0127 ns |  3.642 ns |  0.94 |    0.14 |      - |     - |     - |         - |
|            ForEachWrap |  128 | 15.089 ns | 0.0370 ns | 0.0346 ns | 15.076 ns |  3.88 |    0.58 |      - |     - |     - |         - |
| ForEachWrapNoInterface |  128 | 14.991 ns | 0.0458 ns | 0.0428 ns | 14.998 ns |  3.86 |    0.58 |      - |     - |     - |         - |
|                        |      |           |           |           |           |       |         |        |       |       |           |
|            ForEachList | 2048 |  3.486 ns | 0.1129 ns | 0.1160 ns |  3.426 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|             ForEachBox | 2048 | 15.548 ns | 0.0515 ns | 0.0482 ns | 15.530 ns |  4.45 |    0.15 | 0.0127 |     - |     - |      40 B |
|      ForEachUnderlying | 2048 |  3.660 ns | 0.0161 ns | 0.0143 ns |  3.656 ns |  1.05 |    0.03 |      - |     - |     - |         - |
|            ForEachWrap | 2048 | 15.074 ns | 0.0597 ns | 0.0529 ns | 15.081 ns |  4.31 |    0.15 |      - |     - |     - |         - |
| ForEachWrapNoInterface | 2048 | 14.942 ns | 0.0557 ns | 0.0521 ns | 14.940 ns |  4.28 |    0.14 |      - |     - |     - |         - |