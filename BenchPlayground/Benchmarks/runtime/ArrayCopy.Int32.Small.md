```ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
```

|   Method | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |
|--------- |------ |----------:|----------:|----------:|------:|--------:|
|     Loop |     1 |  5.161 ns | 0.0666 ns | 0.0623 ns |  1.00 |    0.00 |
| Copy3Arg |     1 | 21.883 ns | 0.1231 ns | 0.1152 ns |  4.24 |    0.05 |
| Copy5Arg |     1 | 15.604 ns | 0.1067 ns | 0.0998 ns |  3.02 |    0.05 |
|          |       |           |           |           |       |         |
|     Loop |     2 |  5.940 ns | 0.0802 ns | 0.0750 ns |  1.00 |    0.00 |
| Copy3Arg |     2 | 20.452 ns | 0.2201 ns | 0.2058 ns |  3.44 |    0.06 |
| Copy5Arg |     2 | 14.264 ns | 0.0991 ns | 0.0927 ns |  2.40 |    0.04 |
|          |       |           |           |           |       |         |
|     Loop |     4 |  7.416 ns | 0.0501 ns | 0.0418 ns |  1.00 |    0.00 |
| Copy3Arg |     4 | 20.955 ns | 0.2303 ns | 0.2154 ns |  2.83 |    0.03 |
| Copy5Arg |     4 | 14.615 ns | 0.1406 ns | 0.1316 ns |  1.97 |    0.02 |
|          |       |           |           |           |       |         |
|     Loop |     8 | 10.510 ns | 0.0733 ns | 0.0612 ns |  1.00 |    0.00 |
| Copy3Arg |     8 | 22.872 ns | 0.1338 ns | 0.1252 ns |  2.18 |    0.01 |
| Copy5Arg |     8 | 15.903 ns | 0.2266 ns | 0.2120 ns |  1.51 |    0.03 |
|          |       |           |           |           |       |         |
|     Loop |    16 | 16.419 ns | 0.1242 ns | 0.1101 ns |  1.00 |    0.00 |
| Copy3Arg |    16 | 24.314 ns | 0.2204 ns | 0.1954 ns |  1.48 |    0.01 |
| Copy5Arg |    16 | 18.590 ns | 0.3893 ns | 0.3251 ns |  1.13 |    0.02 |
|          |       |           |           |           |       |         |
|     Loop |    32 | 31.210 ns | 0.3479 ns | 0.3254 ns |  1.00 |    0.00 |
| Copy3Arg |    32 | 28.378 ns | 0.2313 ns | 0.2164 ns |  0.91 |    0.01 |
| Copy5Arg |    32 | 22.638 ns | 0.1970 ns | 0.1747 ns |  0.73 |    0.01 |