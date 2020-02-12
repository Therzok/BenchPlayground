``` ini

BenchmarkDotNet=v0.12.0, OS=macOS 10.15.3 (19D76) [Darwin 19.3.0]
Intel Core i7-4980HQ CPU 2.80GHz (Haswell), 1 CPU, 8 logical and 4 physical cores
  [Host]     : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 
  DefaultJob : Mono 6.10.0.64 (2019-12/0011444f0b6 Tue), X64 

```

|             Method |          Data |      Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------- |-------------- |----------:|----------:|----------:|------:|--------:|
|       AppendFormat | System.Byte[] |  2.211 us | 0.0057 us | 0.0053 us |  1.48 |    0.01 |
|       AppendFormat | System.Byte[] | 16.371 us | 0.0478 us | 0.0424 us | 10.92 |    0.03 |
|       AppendFormat | System.Byte[] | 32.133 us | 0.2529 us | 0.2366 us | 21.44 |    0.18 |
|             Append | System.Byte[] |  1.499 us | 0.0031 us | 0.0026 us |  1.00 |    0.00 |
|             Append | System.Byte[] | 13.299 us | 0.2126 us | 0.1988 us |  8.87 |    0.13 |
|             Append | System.Byte[] | 21.299 us | 0.0485 us | 0.0430 us | 14.21 |    0.04 |
| AppendInterpolated | System.Byte[] |  3.115 us | 0.0087 us | 0.0082 us |  2.08 |    0.01 |
| AppendInterpolated | System.Byte[] | 23.802 us | 0.0678 us | 0.0634 us | 15.89 |    0.05 |
| AppendInterpolated | System.Byte[] | 47.094 us | 0.0737 us | 0.0616 us | 31.43 |    0.07 |