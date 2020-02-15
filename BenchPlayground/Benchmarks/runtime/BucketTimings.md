``` ini

BenchmarkDoBenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 

```

// * Summary *

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 


|           Method | MaximumValue |         Mean |       Error |      StdDev | Ratio | RatioSD |
|----------------- |------------- |-------------:|------------:|------------:|------:|--------:|
|              Add |            8 |     170.9 ns |     0.66 ns |     0.62 ns |  1.00 |    0.00 |
|    AddDescending |            8 |     171.1 ns |     0.65 ns |     0.61 ns |  1.00 |    0.00 |
|        AddRandom |            8 |     171.5 ns |     0.73 ns |     0.69 ns |  1.00 |    0.00 |
|           AddLog |            8 |           NA |          NA |          NA |     ? |       ? |
| AddLogDescending |            8 |           NA |          NA |          NA |     ? |       ? |
|     AddLogRandom |            8 |           NA |          NA |          NA |     ? |       ? |
|                  |              |              |             |             |       |         |
|              Add |           32 |     843.8 ns |     2.25 ns |     2.10 ns |  1.00 |    0.00 |
|    AddDescending |           32 |     837.2 ns |     2.06 ns |     1.93 ns |  0.99 |    0.00 |
|        AddRandom |           32 |     996.7 ns |     3.11 ns |     2.76 ns |  1.18 |    0.00 |
|           AddLog |           32 |   3,006.6 ns |     4.35 ns |     4.07 ns |  3.56 |    0.01 |
| AddLogDescending |           32 |   3,028.1 ns |     7.18 ns |     6.00 ns |  3.59 |    0.01 |
|     AddLogRandom |           32 |   3,262.8 ns |     4.53 ns |     4.02 ns |  3.87 |    0.01 |
|                  |              |              |             |             |       |         |
|              Add |          128 |   3,967.5 ns |    14.45 ns |    12.81 ns |  1.00 |    0.00 |
|    AddDescending |          128 |   3,954.7 ns |    16.08 ns |    15.04 ns |  1.00 |    0.01 |
|        AddRandom |          128 |   4,477.7 ns |    10.52 ns |     9.33 ns |  1.13 |    0.00 |
|           AddLog |          128 |  11,788.5 ns |    23.80 ns |    22.27 ns |  2.97 |    0.01 |
| AddLogDescending |          128 |  11,827.5 ns |    16.74 ns |    15.66 ns |  2.98 |    0.01 |
|     AddLogRandom |          128 |  13,141.7 ns |    15.14 ns |    14.16 ns |  3.31 |    0.01 |
|                  |              |              |             |             |       |         |
|              Add |          512 |  19,162.1 ns |    47.22 ns |    39.43 ns |  1.00 |    0.00 |
|    AddDescending |          512 |  19,130.4 ns |    56.99 ns |    53.31 ns |  1.00 |    0.00 |
|        AddRandom |          512 |  21,579.6 ns |    66.59 ns |    62.29 ns |  1.13 |    0.00 |
|           AddLog |          512 |  46,938.4 ns |    67.30 ns |    62.95 ns |  2.45 |    0.00 |
| AddLogDescending |          512 |  47,043.4 ns |    69.52 ns |    65.03 ns |  2.46 |    0.01 |
|     AddLogRandom |          512 |  52,562.8 ns |    70.30 ns |    62.32 ns |  2.74 |    0.01 |
|                  |              |              |             |             |       |         |
|              Add |         2048 |  90,255.7 ns |   354.83 ns |   331.90 ns |  1.00 |    0.00 |
|    AddDescending |         2048 |  90,274.1 ns |   273.13 ns |   255.48 ns |  1.00 |    0.00 |
|        AddRandom |         2048 | 101,185.9 ns | 1,391.97 ns | 1,302.05 ns |  1.12 |    0.01 |
|           AddLog |         2048 | 187,002.9 ns |   183.57 ns |   171.71 ns |  2.07 |    0.01 |
| AddLogDescending |         2048 | 188,299.1 ns |   335.95 ns |   314.24 ns |  2.09 |    0.01 |
|     AddLogRandom |         2048 | 210,161.8 ns |   279.10 ns |   247.41 ns |  2.33 |    0.01 |