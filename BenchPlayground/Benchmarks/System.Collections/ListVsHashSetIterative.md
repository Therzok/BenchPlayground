``` ini

`<int>`
BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64  [AttachedDebugger]
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 


| Method | Count |          Mean |        Error |       StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|------- |------ |--------------:|-------------:|-------------:|-------:|-------:|-------:|----------:|
|   List |     1 |      37.31 ns |     0.173 ns |     0.135 ns | 0.0250 |      - |      - |         - |
|    Set |     1 |      69.22 ns |     0.440 ns |     0.412 ns | 0.0465 |      - |      - |         - |
|   List |    16 |   1,417.14 ns |     2.053 ns |     1.820 ns | 0.0877 |      - |      - |         - |
|    Set |    16 |     802.47 ns |     1.597 ns |     1.416 ns | 0.1955 |      - |      - |         - |
|   List |   512 | 912,757.05 ns | 5,796.985 ns | 5,422.504 ns | 1.9531 |      - |      - |         - |
|    Set |   512 |  30,371.67 ns |    83.506 ns |    78.112 ns | 5.3406 | 0.8850 | 0.8850 |         - |


`<Object>`
BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64  [AttachedDebugger]
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 


| Method | Count |           Mean |       Error |      StdDev |  Gen 0 |  Gen 1 |  Gen 2 | Allocated |
|------- |------ |---------------:|------------:|------------:|-------:|-------:|-------:|----------:|
|   List |     1 |       380.4 ns |     1.16 ns |     1.08 ns | 0.0362 |      - |      - |         - |
|    Set |     1 |       457.8 ns |     1.20 ns |     1.12 ns | 0.0558 |      - |      - |         - |
|   List |    16 |     7,488.0 ns |    12.50 ns |    10.44 ns | 0.2060 |      - |      - |         - |
|    Set |    16 |     7,487.4 ns |    21.41 ns |    18.98 ns | 0.3204 |      - |      - |         - |
|   List |   512 | 1,116,727.3 ns | 2,746.88 ns | 2,435.04 ns | 3.9063 |      - |      - |         - |
|    Set |   512 |   259,727.5 ns | 1,005.59 ns |   940.63 ns | 6.3477 | 1.9531 | 1.9531 |         - |

