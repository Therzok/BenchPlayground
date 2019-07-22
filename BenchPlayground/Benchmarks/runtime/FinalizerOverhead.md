``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|                             Method |        Mean |      Error |     StdDev |
|----------------------------------- |------------:|-----------:|-----------:|
|                     AllocateSimple |    391.8 us |   4.680 us |   4.378 us |
|        AllocateSimpleWithFinalizer | 10,686.2 us | 189.177 us | 176.957 us |
|          AllocateSimpleWithDispose |    389.7 us |   3.662 us |   3.426 us |
| AllocateSimpleWithFinalizerDispose |  4,685.3 us |  16.757 us |  15.674 us |
