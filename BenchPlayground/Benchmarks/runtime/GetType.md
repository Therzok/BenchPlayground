``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 

```

|          Method |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------- |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
|   GetTypeGlobal | 7.278 us | 0.0363 us | 0.0322 us |  5.59 |    0.06 | 0.1221 |     - |     - |         - |
| GetTypeAssembly | 1.300 us | 0.0135 us | 0.0127 us |  1.00 |    0.00 |      - |     - |     - |         - |