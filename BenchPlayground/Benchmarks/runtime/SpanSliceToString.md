``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.1 (19B88) [Darwin 19.0.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.100-preview3-014645
  [Host]     : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT
  DefaultJob : .NET Core 3.0.0 (CoreCLR 4.700.19.46205, CoreFX 4.700.19.46214), X64 RyuJIT


```
|        Method |                input |          Mean |       Error |        StdDev | Ratio | RatioSD |   Gen 0 |   Gen 1 |   Gen 2 | Allocated |
|-------------- |--------------------- |--------------:|------------:|--------------:|------:|--------:|--------:|--------:|--------:|----------:|
|     **Substring** |                    **a** |      **2.009 ns** |   **0.0474 ns** |     **0.0444 ns** |  **0.30** |    **0.01** |       **-** |       **-** |       **-** |         **-** |
| SliceToString |                    a |      6.664 ns |   0.0250 ns |     0.0234 ns |  1.00 |    0.00 |       - |       - |       - |         - |
|               |                      |               |             |               |       |         |         |         |         |           |
|     **Substring** | **aaaaa(...)aaaaa [32]** |     **15.126 ns** |   **0.0979 ns** |     **0.0916 ns** |  **0.89** |    **0.01** |  **0.0280** |       **-** |       **-** |      **88 B** |
| SliceToString | aaaaa(...)aaaaa [32] |     17.034 ns |   0.0815 ns |     0.0762 ns |  1.00 |    0.00 |  0.0280 |       - |       - |      88 B |
|               |                      |               |             |               |       |         |         |         |         |           |
|     **Substring** |  **aaaa(...)aaaa [128]** |     **28.841 ns** |   **0.2408 ns** |     **0.2253 ns** |  **0.95** |    **0.01** |  **0.0892** |       **-** |       **-** |     **280 B** |
| SliceToString |  aaaa(...)aaaa [128] |     30.455 ns |   0.1574 ns |     0.1473 ns |  1.00 |    0.00 |  0.0892 |       - |       - |     280 B |
|               |                      |               |             |               |       |         |         |         |         |           |
|     **Substring** |  **aaa(...)aaa [16384]** |  **2,852.874 ns** |  **49.1117 ns** |    **45.9391 ns** |  **1.00** |    **0.02** | **10.4141** |       **-** |       **-** |   **32792 B** |
| SliceToString |  aaa(...)aaa [16384] |  2,838.796 ns |  20.3262 ns |    18.0187 ns |  1.00 |    0.00 | 10.4141 |       - |       - |   32792 B |
|               |                      |               |             |               |       |         |         |         |         |           |
|     **Substring** | **aaa(...)aaa [131072]** | **39,848.562 ns** | **791.8256 ns** | **1,232.7770 ns** |  **1.00** |    **0.04** | **68.2983** | **68.1763** | **68.1763** |  **262168 B** |
| SliceToString | aaa(...)aaa [131072] | 40,044.857 ns | 797.0897 ns | 1,217.2402 ns |  1.00 |    0.00 | 67.9321 | 67.8101 | 67.5049 |  262168 B |
