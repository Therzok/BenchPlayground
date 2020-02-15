﻿```ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
```

|   Method | Count |          Mean |        Error |        StdDev |        Median | Ratio | RatioSD |
|--------- |------ |--------------:|-------------:|--------------:|--------------:|------:|--------:|
|     Loop |     8 |      29.39 ns |     0.205 ns |      0.192 ns |      29.34 ns |  1.00 |    0.00 |
| Copy3Arg |     8 |      30.97 ns |     0.247 ns |      0.206 ns |      31.00 ns |  1.05 |    0.01 |
| Copy5Arg |     8 |      24.70 ns |     0.092 ns |      0.082 ns |      24.70 ns |  0.84 |    0.01 |
|          |       |               |              |               |               |       |         |
|     Loop |    32 |     104.38 ns |     0.346 ns |      0.324 ns |     104.32 ns |  1.00 |    0.00 |
| Copy3Arg |    32 |      44.21 ns |     0.239 ns |      0.223 ns |      44.15 ns |  0.42 |    0.00 |
| Copy5Arg |    32 |      38.39 ns |     0.262 ns |      0.233 ns |      38.34 ns |  0.37 |    0.00 |
|          |       |               |              |               |               |       |         |
|     Loop |   128 |     388.78 ns |     1.495 ns |      1.398 ns |     389.16 ns |  1.00 |    0.00 |
| Copy3Arg |   128 |      98.49 ns |     1.315 ns |      1.230 ns |      98.16 ns |  0.25 |    0.00 |
| Copy5Arg |   128 |      92.57 ns |     1.151 ns |      1.020 ns |      92.22 ns |  0.24 |    0.00 |
|          |       |               |              |               |               |       |         |
|     Loop |   512 |   1,539.40 ns |     4.547 ns |      4.031 ns |   1,539.29 ns |  1.00 |    0.00 |
| Copy3Arg |   512 |     326.20 ns |     2.868 ns |      2.683 ns |     326.34 ns |  0.21 |    0.00 |
| Copy5Arg |   512 |     322.47 ns |     3.437 ns |      3.215 ns |     322.37 ns |  0.21 |    0.00 |
|          |       |               |              |               |               |       |         |
|     Loop |  2048 |   6,030.48 ns |    19.659 ns |     16.416 ns |   6,030.85 ns |  1.00 |    0.00 |
| Copy3Arg |  2048 |   1,254.25 ns |    23.918 ns |     27.544 ns |   1,256.27 ns |  0.21 |    0.00 |
| Copy5Arg |  2048 |   1,257.94 ns |    22.166 ns |     20.734 ns |   1,256.02 ns |  0.21 |    0.00 |
|          |       |               |              |               |               |       |         |
|     Loop |  8196 |  24,433.30 ns |   118.214 ns |    110.578 ns |  24,436.74 ns |  1.00 |    0.00 |
| Copy3Arg |  8196 |   6,700.73 ns |    44.810 ns |     41.915 ns |   6,696.84 ns |  0.27 |    0.00 |
| Copy5Arg |  8196 |   6,594.39 ns |    43.972 ns |     41.131 ns |   6,591.83 ns |  0.27 |    0.00 |
|          |       |               |              |               |               |       |         |
|     Loop | 32784 | 132,511.22 ns |   354.403 ns |    295.943 ns | 132,523.25 ns |  1.00 |    0.00 |
| Copy3Arg | 32784 |  70,203.65 ns | 9,560.007 ns | 18,188.907 ns |  60,314.90 ns |  0.72 |    0.11 |
| Copy5Arg | 32784 |  60,208.29 ns |   791.187 ns |    740.077 ns |  60,462.03 ns |  0.45 |    0.01 |