``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.4 (19E287) [Darwin 19.4.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.300
  [Host]     : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT
  DefaultJob : .NET Core 3.1.4 (CoreCLR 4.700.20.20201, CoreFX 4.700.20.22101), X64 RyuJIT


```
|       Method |                Value |       Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------- |--------------------- |-----------:|----------:|----------:|-------:|------:|------:|----------:|
|      LinqAny | BenchPlayground.Core |  40.469 ns | 0.5615 ns | 0.5252 ns | 0.0306 |     - |     - |      96 B |
| LinqContains | BenchPlayground.Core |  29.091 ns | 0.1792 ns | 0.1497 ns | 0.0102 |     - |     - |      32 B |
| BinarySearch | BenchPlayground.Core |  80.904 ns | 0.4648 ns | 0.4348 ns |      - |     - |     - |         - |
|    ArrayLoop | BenchPlayground.Core |   4.955 ns | 0.0131 ns | 0.0122 ns |      - |     - |     - |         - |
|          Set | BenchPlayground.Core |  33.160 ns | 0.1429 ns | 0.1337 ns |      - |     - |     - |         - |
|      LinqAny | Bench(...)lMiss [27] |  64.070 ns | 0.2491 ns | 0.2330 ns | 0.0305 |     - |     - |      96 B |
| LinqContains | Bench(...)lMiss [27] |  53.237 ns | 0.2159 ns | 0.1914 ns | 0.0102 |     - |     - |      32 B |
| BinarySearch | Bench(...)lMiss [27] | 114.120 ns | 0.5385 ns | 0.5038 ns |      - |     - |     - |         - |
|    ArrayLoop | Bench(...)lMiss [27] |  11.784 ns | 0.1345 ns | 0.1258 ns |      - |     - |     - |         - |
|          Set | Bench(...)lMiss [27] |  37.644 ns | 0.1463 ns | 0.1368 ns |      - |     - |     - |         - |
|      LinqAny | DifferentLetter.Miss |  65.198 ns | 0.4681 ns | 0.4378 ns | 0.0305 |     - |     - |      96 B |
| LinqContains | DifferentLetter.Miss |  56.150 ns | 0.2292 ns | 0.2144 ns | 0.0102 |     - |     - |      32 B |
| BinarySearch | DifferentLetter.Miss |  69.117 ns | 0.3146 ns | 0.2942 ns |      - |     - |     - |         - |
|    ArrayLoop | DifferentLetter.Miss |  16.382 ns | 0.1331 ns | 0.1180 ns |      - |     - |     - |         - |
|          Set | DifferentLetter.Miss |  31.720 ns | 0.0678 ns | 0.0566 ns |      - |     - |     - |         - |