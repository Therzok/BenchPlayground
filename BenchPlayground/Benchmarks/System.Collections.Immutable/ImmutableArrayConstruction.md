``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|                       Method | initialCapacity |     Mean |     Error |    StdDev |   Median |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|----------------------------- |---------------- |---------:|----------:|----------:|---------:|--------:|--------:|------:|----------:|
|                         **List** |               **0** | **21.08 us** | **0.4121 us** | **0.5212 us** | **21.36 us** | **40.6494** |  **8.1177** |     **-** | **167.41 KB** |
|      ArrayBuilderToImmutable |               0 | 20.21 us | 0.0640 us | 0.0534 us | 20.18 us | 40.8020 | 10.1624 |     - | 167.49 KB |
| ArrayBuilderMaybeToImmutable |               0 | 20.35 us | 0.0689 us | 0.0645 us | 20.37 us | 40.8020 | 10.1624 |     - | 167.49 KB |
|      **ArrayBuilderToImmutable** |               **8** | **19.77 us** | **0.3921 us** | **0.5496 us** | **20.11 us** | **40.6494** |  **8.1177** |     **-** | **167.37 KB** |
| ArrayBuilderMaybeToImmutable |               8 | 19.18 us | 0.1274 us | 0.0995 us | 19.19 us | 40.5273 |  0.0305 |     - | 167.37 KB |
|                         **List** |           **10000** | **15.57 us** | **0.0181 us** | **0.0161 us** | **15.56 us** | **19.0430** |  **2.3804** |     **-** |   **78.2 KB** |
|      ArrayBuilderToImmutable |           10000 | 14.82 us | 0.0380 us | 0.0337 us | 14.82 us | 19.0430 |  2.3804 |     - |   78.2 KB |
| ArrayBuilderMaybeToImmutable |           10000 | 12.35 us | 0.0142 us | 0.0126 us | 12.34 us |  9.5215 |       - |     - |  39.12 KB |
