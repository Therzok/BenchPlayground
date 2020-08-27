``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.5 (19F101) [Darwin 19.5.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.401
  [Host]     : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.7 (CoreCLR 4.700.20.36602, CoreFX 4.700.20.37001), X64 RyuJIT


```
|                    Method | Offset |      Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|-------------------------- |------- |----------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|                 Substring |      0 |  1.979 ns | 0.0240 ns | 0.0224 ns |  1.00 |    0.00 |      - |     - |     - |         - |
|             SliceToString |      0 | 14.351 ns | 0.1919 ns | 0.1795 ns |  7.25 |    0.13 | 0.0102 |     - |     - |      32 B |
| SliceToStringWithOriginal |      0 |  1.018 ns | 0.0292 ns | 0.0273 ns |  0.51 |    0.02 |      - |     - |     - |         - |
|                           |        |           |           |           |       |         |        |       |       |           |
|                 Substring |      1 | 12.011 ns | 0.3396 ns | 0.4171 ns |  1.00 |    0.00 | 0.0102 |     - |     - |      32 B |
|             SliceToString |      1 | 14.738 ns | 0.1127 ns | 0.1054 ns |  1.22 |    0.05 | 0.0102 |     - |     - |      32 B |
| SliceToStringWithOriginal |      1 | 15.066 ns | 0.1312 ns | 0.1227 ns |  1.24 |    0.05 | 0.0102 |     - |     - |      32 B |