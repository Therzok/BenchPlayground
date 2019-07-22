``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.17134.885 (1803/April2018Update/Redstone4)
Intel Core i7-7700K CPU 4.20GHz (Kaby Lake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|             Method | Categories |      A |      B |         Mean |       Error |      StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------- |----------- |------- |------- |-------------:|------------:|------------:|------:|--------:|-------:|------:|------:|----------:|
|             **Concat** |     **Create** | **Array0** | **Array0** |  **2,557.67 ns** |   **5.8490 ns** |   **5.4712 ns** |  **1.00** |    **0.00** | **1.5259** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array0 | Array0 | 17,649.96 ns |  25.5183 ns |  23.8699 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array0 | Array0 |    413.99 ns |   0.6874 ns |   0.5740 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array0 | Array0 |    406.15 ns |   0.7510 ns |   0.6271 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array0 | Array0 |    443.88 ns |   0.5632 ns |   0.4993 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array0 | Array0 |    496.69 ns |   9.8163 ns |  16.1285 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array0** | **Array1** |  **2,684.79 ns** |   **8.6158 ns** |   **7.1946 ns** |  **1.00** |    **0.00** | **1.5259** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array0 | Array1 | 15,869.26 ns |  12.0569 ns |  10.0680 ns |  1.00 |    0.00 | 2.2888 |     - |     - |    9592 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array0 | Array1 |  3,190.70 ns |   5.4709 ns |   4.8498 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array0 | Array1 | 19,513.46 ns |  15.9347 ns |  14.1257 ns |     ? |       ? | 2.2583 |     - |     - |    9528 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array0 | Array1 |  3,296.31 ns |   7.2976 ns |   5.6975 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array0 | Array1 | 15,840.12 ns | 140.0590 ns | 124.1586 ns |     ? |       ? | 2.2583 |     - |     - |    9528 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array0** |  **Enum0** |  **1,607.29 ns** |   **6.0109 ns** |   **5.3285 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array0 |  Enum0 | 13,194.13 ns |  15.6803 ns |  14.6674 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array0 |  Enum0 |     95.03 ns |   0.3205 ns |   0.2998 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array0 |  Enum0 |    105.26 ns |   0.0937 ns |   0.0782 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array0 |  Enum0 |    128.75 ns |   0.6344 ns |   0.5934 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array0 |  Enum0 |    175.71 ns |   0.5459 ns |   0.4558 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array0** |  **Enum1** |  **1,813.24 ns** |  **25.7323 ns** |  **22.8110 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array0 |  Enum1 | 18,249.28 ns |  34.2205 ns |  32.0099 ns |  1.00 |    0.00 | 2.4719 |     - |     - |   10392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array0 |  Enum1 |  2,036.26 ns |   7.1116 ns |   6.3042 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array0 |  Enum1 | 18,426.19 ns |  98.9030 ns |  92.5139 ns |     ? |       ? | 2.4414 |     - |     - |   10328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array0 |  Enum1 |  2,116.85 ns |  16.6871 ns |  15.6091 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array0 |  Enum1 | 17,125.01 ns |  12.3052 ns |  11.5103 ns |     ? |       ? | 2.4414 |     - |     - |   10328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array1** | **Array0** |  **2,690.26 ns** |  **12.3831 ns** |  **10.9773 ns** |  **1.00** |    **0.00** | **1.5259** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array1 | Array0 | 15,932.06 ns |  34.9732 ns |  31.0029 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6424 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array1 | Array0 |    415.60 ns |   2.5439 ns |   2.3796 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array1 | Array0 |    417.76 ns |   1.5863 ns |   1.4062 ns |     ? |       ? | 0.0076 |     - |     - |      32 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array1 | Array0 |    735.49 ns |   2.1319 ns |   1.7802 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array1 | Array0 |    843.50 ns |   0.9600 ns |   0.8980 ns |     ? |       ? | 0.0076 |     - |     - |      32 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array1** | **Array1** |  **2,676.14 ns** |   **6.7682 ns** |   **5.6518 ns** |  **1.00** |    **0.00** | **1.5259** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array1 | Array1 | 15,938.64 ns |  13.4952 ns |  10.5362 ns |  1.00 |    0.00 | 2.2888 |     - |     - |    9624 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array1 | Array1 |  3,222.56 ns |   4.8624 ns |   4.3104 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array1 | Array1 | 18,826.63 ns |  55.4919 ns |  51.9072 ns |     ? |       ? | 2.2888 |     - |     - |    9624 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array1 | Array1 |  3,306.92 ns |   5.3062 ns |   4.9634 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array1 | Array1 | 17,513.67 ns |  25.7928 ns |  22.8647 ns |     ? |       ? | 2.2888 |     - |     - |    9624 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array1** |  **Enum0** |  **1,615.07 ns** |   **4.5841 ns** |   **4.2880 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array1 |  Enum0 | 13,275.32 ns |  63.7733 ns |  53.2536 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6424 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array1 |  Enum0 |     94.75 ns |   0.0305 ns |   0.0271 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array1 |  Enum0 |    117.63 ns |   0.1474 ns |   0.1231 ns |     ? |       ? | 0.0076 |     - |     - |      32 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array1 |  Enum0 |    421.23 ns |   1.0295 ns |   0.9630 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array1 |  Enum0 |    497.70 ns |   2.1543 ns |   2.0151 ns |     ? |       ? | 0.0076 |     - |     - |      32 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** | **Array1** |  **Enum1** |  **1,609.86 ns** |   **6.8908 ns** |   **6.4457 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume | Array1 |  Enum1 | 15,449.97 ns |  92.8889 ns |  86.8884 ns |  1.00 |    0.00 | 2.4719 |     - |     - |   10424 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create | Array1 |  Enum1 |  2,039.73 ns |   2.9813 ns |   2.7887 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume | Array1 |  Enum1 | 18,425.52 ns |  80.0498 ns |  62.4976 ns |     ? |       ? | 2.4719 |     - |     - |   10424 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create | Array1 |  Enum1 |  2,116.23 ns |   6.0045 ns |   5.0140 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume | Array1 |  Enum1 | 15,957.37 ns |  37.8871 ns |  33.5859 ns |     ? |       ? | 2.4719 |     - |     - |   10424 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum0** | **Array0** |  **1,645.99 ns** |  **16.2544 ns** |  **15.2044 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum0 | Array0 | 16,771.91 ns |  40.9205 ns |  38.2771 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum0 | Array0 |    414.40 ns |   0.8775 ns |   0.7327 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum0 | Array0 |    422.23 ns |   1.9044 ns |   1.7814 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum0 | Array0 |    457.52 ns |   0.6527 ns |   0.5451 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum0 | Array0 |    468.25 ns |   1.3507 ns |   1.1279 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum0** | **Array1** |  **1,751.30 ns** |  **24.4685 ns** |  **22.8879 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum0 | Array1 | 14,753.43 ns |  28.8306 ns |  25.5576 ns |  1.00 |    0.00 | 2.2888 |     - |     - |    9592 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum0 | Array1 |  3,199.83 ns |   8.1131 ns |   7.5890 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum0 | Array1 | 18,115.04 ns |  26.8458 ns |  20.9594 ns |     ? |       ? | 2.2583 |     - |     - |    9528 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum0 | Array1 |  3,302.50 ns |  29.1796 ns |  27.2946 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum0 | Array1 | 15,797.25 ns |  12.7721 ns |  10.6653 ns |     ? |       ? | 2.2583 |     - |     - |    9528 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum0** |  **Enum0** |  **1,772.39 ns** |   **5.6931 ns** |   **5.0468 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum0 |  Enum0 | 12,854.03 ns |  15.4916 ns |  12.9362 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum0 |  Enum0 |     94.88 ns |   0.2374 ns |   0.2105 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum0 |  Enum0 |    104.27 ns |   0.0495 ns |   0.0387 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum0 |  Enum0 |    125.50 ns |   0.4038 ns |   0.3777 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum0 |  Enum0 |    170.96 ns |   0.0812 ns |   0.0719 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum0** |  **Enum1** |  **1,797.11 ns** |   **4.0848 ns** |   **3.6211 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum0 |  Enum1 | 14,129.03 ns |  16.2534 ns |  14.4082 ns |  1.00 |    0.00 | 2.4719 |     - |     - |   10392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum0 |  Enum1 |  2,068.95 ns |   5.4170 ns |   5.0670 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum0 |  Enum1 | 17,670.08 ns |  19.8880 ns |  17.6302 ns |     ? |       ? | 2.4414 |     - |     - |   10328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum0 |  Enum1 |  2,116.00 ns |   5.4806 ns |   5.1266 ns |     ? |       ? | 1.5106 |     - |     - |    6328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum0 |  Enum1 | 15,496.76 ns |  15.0715 ns |  14.0978 ns |     ? |       ? | 2.4414 |     - |     - |   10328 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum1** | **Array0** |  **1,638.95 ns** |   **4.1906 ns** |   **3.7148 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum1 | Array0 | 15,381.54 ns |  16.0128 ns |  13.3714 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6432 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum1 | Array0 |    413.59 ns |   0.5925 ns |   0.4948 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum1 | Array0 |    463.34 ns |   1.8095 ns |   1.6926 ns |     ? |       ? | 0.0095 |     - |     - |      40 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum1 | Array0 |    556.08 ns |   9.0183 ns |   8.4357 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum1 | Array0 |    670.80 ns |   1.2951 ns |   1.1481 ns |     ? |       ? | 0.0095 |     - |     - |      40 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum1** | **Array1** |  **1,659.75 ns** |  **11.4379 ns** |  **10.1394 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum1 | Array1 | 15,020.29 ns |  15.9836 ns |  14.1690 ns |  1.00 |    0.00 | 2.2888 |     - |     - |    9632 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum1 | Array1 |  2,203.58 ns |   8.4329 ns |   7.8881 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum1 | Array1 | 17,845.99 ns |  30.6254 ns |  27.1487 ns |     ? |       ? | 2.2888 |     - |     - |    9632 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum1 | Array1 |  2,300.64 ns |  15.5676 ns |  14.5619 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum1 | Array1 | 15,330.91 ns |  54.1945 ns |  48.0420 ns |     ? |       ? | 2.2888 |     - |     - |    9632 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum1** |  **Enum0** |  **1,715.88 ns** |  **28.2245 ns** |  **26.4012 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum1 |  Enum0 | 13,203.40 ns |  81.7712 ns |  72.4881 ns |  1.00 |    0.00 | 1.5259 |     - |     - |    6432 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum1 |  Enum0 |     95.53 ns |   0.5380 ns |   0.4493 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum1 |  Enum0 |    121.16 ns |   0.2648 ns |   0.2477 ns |     ? |       ? | 0.0095 |     - |     - |      40 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum1 |  Enum0 |    246.31 ns |   0.4466 ns |   0.3959 ns |     ? |       ? |      - |     - |     - |         - |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum1 |  Enum0 |    365.01 ns |   2.3036 ns |   2.1548 ns |     ? |       ? | 0.0095 |     - |     - |      40 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|             **Concat** |     **Create** |  **Enum1** |  **Enum1** |  **1,635.26 ns** |  **20.4047 ns** |  **18.0882 ns** |  **1.00** |    **0.00** | **1.5278** |     **-** |     **-** |    **6392 B** |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|      ConcatConsume |    Consume |  Enum1 |  Enum1 | 15,157.28 ns |  95.1491 ns |  89.0025 ns |  1.00 |    0.00 | 2.4872 |     - |     - |   10432 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|            FConcat |     Create |  Enum1 |  Enum1 |  2,044.53 ns |  15.2912 ns |  14.3034 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|     FConcatConsume |    Consume |  Enum1 |  Enum1 | 18,248.44 ns |  49.6545 ns |  46.4469 ns |     ? |       ? | 2.4719 |     - |     - |   10432 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
|        FPartConcat |     Create |  Enum1 |  Enum1 |  2,283.83 ns |  44.8644 ns |  44.0628 ns |     ? |       ? | 1.5259 |     - |     - |    6392 B |
|                    |            |        |        |              |             |             |       |         |        |       |       |           |
| FPartConcatConsume |    Consume |  Enum1 |  Enum1 | 16,207.35 ns | 388.1876 ns | 476.7292 ns |     ? |       ? | 2.4719 |     - |     - |   10432 B |
