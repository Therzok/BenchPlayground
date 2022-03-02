```ini
BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.2.1 (21D62) [Darwin 21.3.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.200
  [Host]     : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
  DefaultJob : .NET 6.0.2 (6.0.222.6406), X64 RyuJIT
```

|        Method |    ComparisonType |                 path |          Mean |      Error |     StdDev |        Median | Ratio | RatioSD |
|-------------- |------------------ |--------------------- |--------------:|-----------:|-----------:|--------------:|------:|--------:|
|   GetHashCode |    CurrentCulture |                    / |   116.5049 ns |  2.3502 ns |  3.7952 ns |   117.4167 ns | 1.000 |    0.00 |
|  GetCacheCode |    CurrentCulture |                    / |     0.0155 ns |  0.0137 ns |  0.0334 ns |     0.0000 ns | 0.000 |    0.00 |
| MakeCacheCode |    CurrentCulture |                    / |   112.3209 ns |  1.1105 ns |  1.0387 ns |   112.5043 ns | 0.987 |    0.03 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |    CurrentCulture | /Appl(...)o.app [31] |   519.8301 ns |  7.0939 ns |  6.6356 ns |   522.3369 ns | 1.000 |    0.00 |
|  GetCacheCode |    CurrentCulture | /Appl(...)o.app [31] |     0.0060 ns |  0.0072 ns |  0.0063 ns |     0.0038 ns | 0.000 |    0.00 |
| MakeCacheCode |    CurrentCulture | /Appl(...)o.app [31] |   520.1487 ns |  6.0910 ns |  5.6975 ns |   519.8654 ns | 1.001 |    0.02 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |    CurrentCulture | /User(...)round [35] |   601.5722 ns |  5.4136 ns |  5.0639 ns |   603.6229 ns | 1.000 |    0.00 |
|  GetCacheCode |    CurrentCulture | /User(...)round [35] |     0.0009 ns |  0.0015 ns |  0.0012 ns |     0.0004 ns | 0.000 |    0.00 |
| MakeCacheCode |    CurrentCulture | /User(...)round [35] |   603.8481 ns |  7.3630 ns |  6.8873 ns |   604.2547 ns | 1.004 |    0.01 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |    CurrentCulture |  /Use(...)ders [136] | 2,190.8679 ns | 25.3177 ns | 23.6822 ns | 2,190.9392 ns | 1.000 |    0.00 |
|  GetCacheCode |    CurrentCulture |  /Use(...)ders [136] |     0.0039 ns |  0.0028 ns |  0.0025 ns |     0.0046 ns | 0.000 |    0.00 |
| MakeCacheCode |    CurrentCulture |  /Use(...)ders [136] | 2,193.6776 ns | 31.8112 ns | 29.7562 ns | 2,195.0567 ns | 1.001 |    0.02 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |           Ordinal |                    / |     2.8174 ns |  0.0100 ns |  0.0089 ns |     2.8194 ns | 1.000 |    0.00 |
|  GetCacheCode |           Ordinal |                    / |     0.0076 ns |  0.0054 ns |  0.0045 ns |     0.0079 ns | 0.003 |    0.00 |
| MakeCacheCode |           Ordinal |                    / |     7.1287 ns |  0.0536 ns |  0.0501 ns |     7.1269 ns | 2.531 |    0.02 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |           Ordinal | /Appl(...)o.app [31] |    17.7772 ns |  0.1172 ns |  0.1039 ns |    17.7296 ns | 1.000 |    0.00 |
|  GetCacheCode |           Ordinal | /Appl(...)o.app [31] |     0.0087 ns |  0.0048 ns |  0.0043 ns |     0.0073 ns | 0.000 |    0.00 |
| MakeCacheCode |           Ordinal | /Appl(...)o.app [31] |    20.1540 ns |  0.4152 ns |  0.4077 ns |    19.9719 ns | 1.132 |    0.03 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |           Ordinal | /User(...)round [35] |    20.2417 ns |  0.1025 ns |  0.0958 ns |    20.1941 ns | 1.000 |    0.00 |
|  GetCacheCode |           Ordinal | /User(...)round [35] |     0.0189 ns |  0.0140 ns |  0.0109 ns |     0.0149 ns | 0.001 |    0.00 |
| MakeCacheCode |           Ordinal | /User(...)round [35] |    22.4321 ns |  0.0593 ns |  0.0463 ns |    22.4313 ns | 1.109 |    0.01 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode |           Ordinal |  /Use(...)ders [136] |    81.8774 ns |  0.1767 ns |  0.1476 ns |    81.8540 ns | 1.000 |    0.00 |
|  GetCacheCode |           Ordinal |  /Use(...)ders [136] |     0.0106 ns |  0.0094 ns |  0.0084 ns |     0.0098 ns | 0.000 |    0.00 |
| MakeCacheCode |           Ordinal |  /Use(...)ders [136] |    83.8499 ns |  0.1282 ns |  0.1070 ns |    83.8523 ns | 1.024 |    0.00 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode | OrdinalIgnoreCase |                    / |     3.0744 ns |  0.0091 ns |  0.0076 ns |     3.0742 ns | 1.000 |    0.00 |
|  GetCacheCode | OrdinalIgnoreCase |                    / |     0.0056 ns |  0.0051 ns |  0.0043 ns |     0.0040 ns | 0.002 |    0.00 |
| MakeCacheCode | OrdinalIgnoreCase |                    / |     7.3906 ns |  0.0308 ns |  0.0273 ns |     7.3906 ns | 2.403 |    0.01 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode | OrdinalIgnoreCase | /Appl(...)o.app [31] |    24.0878 ns |  0.1177 ns |  0.1101 ns |    24.0397 ns | 1.000 |    0.00 |
|  GetCacheCode | OrdinalIgnoreCase | /Appl(...)o.app [31] |     0.0043 ns |  0.0035 ns |  0.0029 ns |     0.0044 ns | 0.000 |    0.00 |
| MakeCacheCode | OrdinalIgnoreCase | /Appl(...)o.app [31] |    27.0614 ns |  0.1334 ns |  0.1183 ns |    27.0234 ns | 1.123 |    0.01 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode | OrdinalIgnoreCase | /User(...)round [35] |    26.7653 ns |  0.0805 ns |  0.0672 ns |    26.7466 ns | 1.000 |    0.00 |
|  GetCacheCode | OrdinalIgnoreCase | /User(...)round [35] |     0.0136 ns |  0.0126 ns |  0.0112 ns |     0.0107 ns | 0.000 |    0.00 |
| MakeCacheCode | OrdinalIgnoreCase | /User(...)round [35] |    29.6791 ns |  0.0694 ns |  0.0579 ns |    29.6770 ns | 1.109 |    0.00 |
|               |                   |                      |               |            |            |               |       |         |
|   GetHashCode | OrdinalIgnoreCase |  /Use(...)ders [136] |    93.2758 ns |  0.3405 ns |  0.3018 ns |    93.1908 ns | 1.000 |    0.00 |
|  GetCacheCode | OrdinalIgnoreCase |  /Use(...)ders [136] |     0.0049 ns |  0.0032 ns |  0.0029 ns |     0.0043 ns | 0.000 |    0.00 |
| MakeCacheCode | OrdinalIgnoreCase |  /Use(...)ders [136] |   101.6432 ns |  0.2860 ns |  0.2535 ns |   101.5656 ns | 1.090 |    0.00 |
