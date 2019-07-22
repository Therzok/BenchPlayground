``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|     Method |      Mean |     Error |    StdDev | Gen 0 | Gen 1 | Gen 2 | Allocated |
|----------- |----------:|----------:|----------:|------:|------:|------:|----------:|
|  BenchDict | 139.29 us | 0.1216 us | 0.1078 us |     - |     - |     - |         - |
| BenchArray |  26.18 us | 0.0041 us | 0.0039 us |     - |     - |     - |         - |
