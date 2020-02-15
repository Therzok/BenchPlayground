```ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
```

|   Method | Count |      Mean |     Error |    StdDev | Ratio | RatioSD |
|--------- |------ |----------:|----------:|----------:|------:|--------:|
|     Loop |     1 |  5.039 ns | 0.0326 ns | 0.0305 ns |  1.00 |    0.00 |
| Copy3Arg |     1 | 21.679 ns | 0.0681 ns | 0.0637 ns |  4.30 |    0.03 |
| Copy5Arg |     1 | 15.476 ns | 0.0810 ns | 0.0632 ns |  3.07 |    0.02 |
|     Span |     1 |  8.150 ns | 0.0546 ns | 0.0484 ns |  1.62 |    0.01 |
|          |       |           |           |           |       |         |
|     Loop |    16 | 16.076 ns | 0.0962 ns | 0.0853 ns |  1.00 |    0.00 |
| Copy3Arg |    16 | 23.715 ns | 0.1901 ns | 0.1778 ns |  1.48 |    0.01 |
| Copy5Arg |    16 | 18.222 ns | 0.0824 ns | 0.0771 ns |  1.13 |    0.01 |
|     Span |    16 | 11.623 ns | 0.1140 ns | 0.1010 ns |  0.72 |    0.01 |
|          |       |           |           |           |       |         |
|     Loop |    32 | 30.684 ns | 0.1605 ns | 0.1423 ns |  1.00 |    0.00 |
| Copy3Arg |    32 | 28.539 ns | 0.1637 ns | 0.1451 ns |  0.93 |    0.00 |
| Copy5Arg |    32 | 22.666 ns | 0.1230 ns | 0.1151 ns |  0.74 |    0.00 |
|     Span |    32 | 16.398 ns | 0.1793 ns | 0.1677 ns |  0.53 |    0.01 |