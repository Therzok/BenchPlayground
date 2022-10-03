```ini
// AfterAll
// Benchmark Process 81424 has exited with code 0.

Mean = 1.686 ns, StdErr = 0.004 ns (0.23%), N = 12, StdDev = 0.013 ns
Min = 1.668 ns, Q1 = 1.677 ns, Median = 1.683 ns, Q3 = 1.693 ns, Max = 1.709 ns
IQR = 0.016 ns, LowerFence = 1.652 ns, UpperFence = 1.718 ns
ConfidenceInterval = [1.669 ns; 1.703 ns] (CI 99.9%), Margin = 0.017 ns (1.01% of Mean)
Skewness = 0.42, Kurtosis = 1.68, MValue = 2

// ***** BenchmarkRunner: Finish  *****

// * Export *
  BenchmarkDotNet.Artifacts/results/BenchPlayground.StringComparisonBench-report.csv
  BenchmarkDotNet.Artifacts/results/BenchPlayground.StringComparisonBench-report-github.md
  BenchmarkDotNet.Artifacts/results/BenchPlayground.StringComparisonBench-report.html

// * Detailed results *
StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=CurrentCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 41.580 ns, StdErr = 0.166 ns (0.40%), N = 18, StdDev = 0.703 ns
Min = 40.695 ns, Q1 = 41.071 ns, Median = 41.430 ns, Q3 = 41.960 ns, Max = 42.903 ns
IQR = 0.889 ns, LowerFence = 39.738 ns, UpperFence = 43.293 ns
ConfidenceInterval = [40.923 ns; 42.237 ns] (CI 99.9%), Margin = 0.657 ns (1.58% of Mean)
Skewness = 0.6, Kurtosis = 2.13, MValue = 2
-------------------- Histogram --------------------
[40.624 ns ; 42.168 ns) | @@@@@@@@@@@@@@@
[42.168 ns ; 43.256 ns) | @@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=Curre(...)eCase [24]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 40.995 ns, StdErr = 0.073 ns (0.18%), N = 13, StdDev = 0.265 ns
Min = 40.598 ns, Q1 = 40.815 ns, Median = 40.910 ns, Q3 = 41.051 ns, Max = 41.467 ns
IQR = 0.236 ns, LowerFence = 40.461 ns, UpperFence = 41.405 ns
ConfidenceInterval = [40.678 ns; 41.312 ns] (CI 99.9%), Margin = 0.317 ns (0.77% of Mean)
Skewness = 0.56, Kurtosis = 2.09, MValue = 2
-------------------- Histogram --------------------
[40.498 ns ; 41.615 ns) | @@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=InvariantCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 32.312 ns, StdErr = 0.052 ns (0.16%), N = 13, StdDev = 0.187 ns
Min = 31.973 ns, Q1 = 32.198 ns, Median = 32.272 ns, Q3 = 32.451 ns, Max = 32.620 ns
IQR = 0.253 ns, LowerFence = 31.819 ns, UpperFence = 32.831 ns
ConfidenceInterval = [32.087 ns; 32.536 ns] (CI 99.9%), Margin = 0.224 ns (0.69% of Mean)
Skewness = -0.03, Kurtosis = 1.89, MValue = 2
-------------------- Histogram --------------------
[31.920 ns ; 32.724 ns) | @@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=Invar(...)eCase [26]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 32.603 ns, StdErr = 0.157 ns (0.48%), N = 15, StdDev = 0.608 ns
Min = 31.896 ns, Q1 = 32.171 ns, Median = 32.583 ns, Q3 = 32.691 ns, Max = 33.816 ns
IQR = 0.520 ns, LowerFence = 31.391 ns, UpperFence = 33.471 ns
ConfidenceInterval = [31.953 ns; 33.253 ns] (CI 99.9%), Margin = 0.650 ns (1.99% of Mean)
Skewness = 0.77, Kurtosis = 2.26, MValue = 2
-------------------- Histogram --------------------
[31.572 ns ; 32.770 ns) | @@@@@@@@@@@@
[32.770 ns ; 34.010 ns) | @@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=Ordinal]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 2.130 ns, StdErr = 0.007 ns (0.35%), N = 14, StdDev = 0.028 ns
Min = 2.096 ns, Q1 = 2.114 ns, Median = 2.122 ns, Q3 = 2.150 ns, Max = 2.179 ns
IQR = 0.037 ns, LowerFence = 2.058 ns, UpperFence = 2.206 ns
ConfidenceInterval = [2.099 ns; 2.162 ns] (CI 99.9%), Margin = 0.032 ns (1.48% of Mean)
Skewness = 0.43, Kurtosis = 1.68, MValue = 2
-------------------- Histogram --------------------
[2.089 ns ; 2.188 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=a, Comparison=OrdinalIgnoreCase]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 1.695 ns, StdErr = 0.006 ns (0.35%), N = 14, StdDev = 0.022 ns
Min = 1.664 ns, Q1 = 1.682 ns, Median = 1.688 ns, Q3 = 1.700 ns, Max = 1.737 ns
IQR = 0.018 ns, LowerFence = 1.655 ns, UpperFence = 1.727 ns
ConfidenceInterval = [1.670 ns; 1.720 ns] (CI 99.9%), Margin = 0.025 ns (1.49% of Mean)
Skewness = 0.76, Kurtosis = 2.27, MValue = 2
-------------------- Histogram --------------------
[1.652 ns ; 1.709 ns) | @@@@@@@@@@@
[1.709 ns ; 1.749 ns) | @@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=CurrentCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 137.380 ns, StdErr = 0.312 ns (0.23%), N = 13, StdDev = 1.125 ns
Min = 135.695 ns, Q1 = 136.578 ns, Median = 137.301 ns, Q3 = 138.235 ns, Max = 139.628 ns
IQR = 1.657 ns, LowerFence = 134.094 ns, UpperFence = 140.720 ns
ConfidenceInterval = [136.033 ns; 138.728 ns] (CI 99.9%), Margin = 1.347 ns (0.98% of Mean)
Skewness = 0.23, Kurtosis = 2, MValue = 2
-------------------- Histogram --------------------
[135.067 ns ; 140.257 ns) | @@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=Curre(...)eCase [24]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 137.460 ns, StdErr = 0.349 ns (0.25%), N = 14, StdDev = 1.304 ns
Min = 135.686 ns, Q1 = 136.276 ns, Median = 137.383 ns, Q3 = 138.595 ns, Max = 139.675 ns
IQR = 2.319 ns, LowerFence = 132.798 ns, UpperFence = 142.073 ns
ConfidenceInterval = [135.989 ns; 138.932 ns] (CI 99.9%), Margin = 1.471 ns (1.07% of Mean)
Skewness = 0.11, Kurtosis = 1.51, MValue = 2
-------------------- Histogram --------------------
[134.976 ns ; 140.386 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=InvariantCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 128.882 ns, StdErr = 0.525 ns (0.41%), N = 15, StdDev = 2.033 ns
Min = 126.642 ns, Q1 = 127.342 ns, Median = 128.743 ns, Q3 = 130.513 ns, Max = 133.137 ns
IQR = 3.171 ns, LowerFence = 122.586 ns, UpperFence = 135.269 ns
ConfidenceInterval = [126.709 ns; 131.055 ns] (CI 99.9%), Margin = 2.173 ns (1.69% of Mean)
Skewness = 0.64, Kurtosis = 2.02, MValue = 2
-------------------- Histogram --------------------
[126.433 ns ; 129.893 ns) | @@@@@@@@@@
[129.893 ns ; 134.219 ns) | @@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=Invar(...)eCase [26]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 128.499 ns, StdErr = 0.395 ns (0.31%), N = 15, StdDev = 1.531 ns
Min = 126.360 ns, Q1 = 127.371 ns, Median = 128.098 ns, Q3 = 129.483 ns, Max = 131.823 ns
IQR = 2.112 ns, LowerFence = 124.204 ns, UpperFence = 132.651 ns
ConfidenceInterval = [126.862 ns; 130.136 ns] (CI 99.9%), Margin = 1.637 ns (1.27% of Mean)
Skewness = 0.69, Kurtosis = 2.32, MValue = 2
-------------------- Histogram --------------------
[125.545 ns ; 129.046 ns) | @@@@@@@@@@@
[129.046 ns ; 132.638 ns) | @@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=Ordinal]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 2.138 ns, StdErr = 0.011 ns (0.50%), N = 15, StdDev = 0.042 ns
Min = 2.087 ns, Q1 = 2.098 ns, Median = 2.131 ns, Q3 = 2.168 ns, Max = 2.208 ns
IQR = 0.071 ns, LowerFence = 1.991 ns, UpperFence = 2.275 ns
ConfidenceInterval = [2.093 ns; 2.183 ns] (CI 99.9%), Margin = 0.045 ns (2.09% of Mean)
Skewness = 0.28, Kurtosis = 1.46, MValue = 2
-------------------- Histogram --------------------
[2.087 ns ; 2.131 ns) | @@@@@@@@
[2.131 ns ; 2.231 ns) | @@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [200], Comparison=OrdinalIgnoreCase]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 1.703 ns, StdErr = 0.012 ns (0.69%), N = 15, StdDev = 0.046 ns
Min = 1.656 ns, Q1 = 1.670 ns, Median = 1.680 ns, Q3 = 1.729 ns, Max = 1.800 ns
IQR = 0.059 ns, LowerFence = 1.582 ns, UpperFence = 1.817 ns
ConfidenceInterval = [1.654 ns; 1.751 ns] (CI 99.9%), Margin = 0.049 ns (2.87% of Mean)
Skewness = 0.76, Kurtosis = 2.11, MValue = 2
-------------------- Histogram --------------------
[1.649 ns ; 1.698 ns) | @@@@@@@@@
[1.698 ns ; 1.771 ns) | @@@@@
[1.771 ns ; 1.824 ns) | @
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=CurrentCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 500.752 ns, StdErr = 2.222 ns (0.44%), N = 15, StdDev = 8.607 ns
Min = 491.540 ns, Q1 = 494.211 ns, Median = 495.684 ns, Q3 = 508.593 ns, Max = 516.909 ns
IQR = 14.382 ns, LowerFence = 472.638 ns, UpperFence = 530.166 ns
ConfidenceInterval = [491.551 ns; 509.954 ns] (CI 99.9%), Margin = 9.201 ns (1.84% of Mean)
Skewness = 0.55, Kurtosis = 1.58, MValue = 2
-------------------- Histogram --------------------
[489.686 ns ; 503.551 ns) | @@@@@@@@@
[503.551 ns ; 521.489 ns) | @@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=Curre(...)eCase [24]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 503.084 ns, StdErr = 1.536 ns (0.31%), N = 15, StdDev = 5.949 ns
Min = 496.115 ns, Q1 = 498.573 ns, Median = 501.812 ns, Q3 = 506.350 ns, Max = 515.789 ns
IQR = 7.778 ns, LowerFence = 486.906 ns, UpperFence = 518.017 ns
ConfidenceInterval = [496.725 ns; 509.443 ns] (CI 99.9%), Margin = 6.359 ns (1.26% of Mean)
Skewness = 0.7, Kurtosis = 2.22, MValue = 2
-------------------- Histogram --------------------
[494.007 ns ; 518.955 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=InvariantCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 500.396 ns, StdErr = 2.833 ns (0.57%), N = 44, StdDev = 18.794 ns
Min = 482.051 ns, Q1 = 486.825 ns, Median = 492.476 ns, Q3 = 509.265 ns, Max = 549.495 ns
IQR = 22.440 ns, LowerFence = 453.166 ns, UpperFence = 542.925 ns
ConfidenceInterval = [490.390 ns; 510.402 ns] (CI 99.9%), Margin = 10.006 ns (2.00% of Mean)
Skewness = 1.24, Kurtosis = 3.41, MValue = 2
-------------------- Histogram --------------------
[480.660 ns ; 494.634 ns) | @@@@@@@@@@@@@@@@@@@@@@@@
[494.634 ns ; 510.431 ns) | @@@@@@@@@@
[510.431 ns ; 521.305 ns) | @@@@
[521.305 ns ; 531.842 ns) |
[531.842 ns ; 556.483 ns) | @@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=Invar(...)eCase [26]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 492.276 ns, StdErr = 2.075 ns (0.42%), N = 13, StdDev = 7.481 ns
Min = 484.624 ns, Q1 = 486.330 ns, Median = 490.356 ns, Q3 = 494.350 ns, Max = 510.707 ns
IQR = 8.019 ns, LowerFence = 474.302 ns, UpperFence = 506.378 ns
ConfidenceInterval = [483.316 ns; 501.235 ns] (CI 99.9%), Margin = 8.959 ns (1.82% of Mean)
Skewness = 1.15, Kurtosis = 3.36, MValue = 2
-------------------- Histogram --------------------
[480.448 ns ; 494.439 ns) | @@@@@@@@@@
[494.439 ns ; 511.909 ns) | @@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=Ordinal]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 2.148 ns, StdErr = 0.013 ns (0.61%), N = 15, StdDev = 0.051 ns
Min = 2.099 ns, Q1 = 2.105 ns, Median = 2.134 ns, Q3 = 2.186 ns, Max = 2.258 ns
IQR = 0.081 ns, LowerFence = 1.984 ns, UpperFence = 2.307 ns
ConfidenceInterval = [2.093 ns; 2.202 ns] (CI 99.9%), Margin = 0.054 ns (2.53% of Mean)
Skewness = 0.68, Kurtosis = 2.08, MValue = 2
-------------------- Histogram --------------------
[2.092 ns ; 2.146 ns) | @@@@@@@@@
[2.146 ns ; 2.220 ns) | @@@@@
[2.220 ns ; 2.285 ns) | @
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [1000], Comparison=OrdinalIgnoreCase]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 1.710 ns, StdErr = 0.014 ns (0.82%), N = 15, StdDev = 0.054 ns
Min = 1.658 ns, Q1 = 1.669 ns, Median = 1.690 ns, Q3 = 1.745 ns, Max = 1.814 ns
IQR = 0.076 ns, LowerFence = 1.556 ns, UpperFence = 1.859 ns
ConfidenceInterval = [1.652 ns; 1.768 ns] (CI 99.9%), Margin = 0.058 ns (3.40% of Mean)
Skewness = 0.79, Kurtosis = 1.92, MValue = 2.6
-------------------- Histogram --------------------
[1.652 ns ; 1.710 ns) | @@@@@@@@@@
[1.710 ns ; 1.765 ns) | @
[1.765 ns ; 1.823 ns) | @@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=CurrentCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 935.983 ns, StdErr = 3.521 ns (0.38%), N = 15, StdDev = 13.637 ns
Min = 922.621 ns, Q1 = 924.823 ns, Median = 928.240 ns, Q3 = 947.595 ns, Max = 962.666 ns
IQR = 22.772 ns, LowerFence = 890.665 ns, UpperFence = 981.754 ns
ConfidenceInterval = [921.404 ns; 950.562 ns] (CI 99.9%), Margin = 14.579 ns (1.56% of Mean)
Skewness = 0.59, Kurtosis = 1.7, MValue = 2
-------------------- Histogram --------------------
[918.716 ns ; 941.134 ns) | @@@@@@@@@@
[941.134 ns ; 969.923 ns) | @@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=Curre(...)eCase [24]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 929.996 ns, StdErr = 2.165 ns (0.23%), N = 14, StdDev = 8.100 ns
Min = 921.908 ns, Q1 = 924.565 ns, Median = 926.494 ns, Q3 = 934.554 ns, Max = 949.567 ns
IQR = 9.989 ns, LowerFence = 909.581 ns, UpperFence = 949.537 ns
ConfidenceInterval = [920.859 ns; 939.133 ns] (CI 99.9%), Margin = 9.137 ns (0.98% of Mean)
Skewness = 1.06, Kurtosis = 2.95, MValue = 2
-------------------- Histogram --------------------
[917.497 ns ; 953.978 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=InvariantCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 926.260 ns, StdErr = 2.112 ns (0.23%), N = 15, StdDev = 8.181 ns
Min = 913.713 ns, Q1 = 919.319 ns, Median = 925.836 ns, Q3 = 931.586 ns, Max = 941.641 ns
IQR = 12.267 ns, LowerFence = 900.918 ns, UpperFence = 949.987 ns
ConfidenceInterval = [917.514 ns; 935.006 ns] (CI 99.9%), Margin = 8.746 ns (0.94% of Mean)
Skewness = 0.19, Kurtosis = 1.86, MValue = 2
-------------------- Histogram --------------------
[909.360 ns ; 945.995 ns) | @@@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=Invar(...)eCase [26]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 926.322 ns, StdErr = 3.180 ns (0.34%), N = 14, StdDev = 11.900 ns
Min = 914.050 ns, Q1 = 917.119 ns, Median = 920.737 ns, Q3 = 932.566 ns, Max = 955.206 ns
IQR = 15.447 ns, LowerFence = 893.948 ns, UpperFence = 955.737 ns
ConfidenceInterval = [912.898 ns; 939.747 ns] (CI 99.9%), Margin = 13.424 ns (1.45% of Mean)
Skewness = 0.94, Kurtosis = 2.9, MValue = 2
-------------------- Histogram --------------------
[907.569 ns ; 926.793 ns) | @@@@@@@@
[926.793 ns ; 961.687 ns) | @@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=Ordinal]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 66.129 ns, StdErr = 0.211 ns (0.32%), N = 14, StdDev = 0.788 ns
Min = 64.857 ns, Q1 = 65.631 ns, Median = 66.040 ns, Q3 = 66.597 ns, Max = 67.898 ns
IQR = 0.967 ns, LowerFence = 64.180 ns, UpperFence = 68.047 ns
ConfidenceInterval = [65.240 ns; 67.019 ns] (CI 99.9%), Margin = 0.889 ns (1.34% of Mean)
Skewness = 0.44, Kurtosis = 2.69, MValue = 2
-------------------- Histogram --------------------
[64.428 ns ; 66.845 ns) | @@@@@@@@@@@@
[66.845 ns ; 68.328 ns) | @@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [2000], Comparison=OrdinalIgnoreCase]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 907.181 ns, StdErr = 1.769 ns (0.19%), N = 14, StdDev = 6.619 ns
Min = 898.529 ns, Q1 = 902.645 ns, Median = 904.815 ns, Q3 = 912.417 ns, Max = 920.075 ns
IQR = 9.773 ns, LowerFence = 887.985 ns, UpperFence = 927.077 ns
ConfidenceInterval = [899.714 ns; 914.648 ns] (CI 99.9%), Margin = 7.467 ns (0.82% of Mean)
Skewness = 0.33, Kurtosis = 1.74, MValue = 2
-------------------- Histogram --------------------
[894.924 ns ; 923.679 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=CurrentCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 946.375 ns, StdErr = 2.870 ns (0.30%), N = 14, StdDev = 10.738 ns
Min = 934.571 ns, Q1 = 937.603 ns, Median = 944.922 ns, Q3 = 950.739 ns, Max = 972.219 ns
IQR = 13.136 ns, LowerFence = 917.899 ns, UpperFence = 970.443 ns
ConfidenceInterval = [934.262 ns; 958.488 ns] (CI 99.9%), Margin = 12.113 ns (1.28% of Mean)
Skewness = 0.88, Kurtosis = 2.9, MValue = 2
-------------------- Histogram --------------------
[930.519 ns ; 978.066 ns) | @@@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=Curre(...)eCase [24]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 959.212 ns, StdErr = 5.030 ns (0.52%), N = 24, StdDev = 24.644 ns
Min = 937.666 ns, Q1 = 940.761 ns, Median = 947.044 ns, Q3 = 970.672 ns, Max = 1,015.783 ns
IQR = 29.911 ns, LowerFence = 895.895 ns, UpperFence = 1,015.539 ns
ConfidenceInterval = [940.259 ns; 978.165 ns] (CI 99.9%), Margin = 18.953 ns (1.98% of Mean)
Skewness = 1.01, Kurtosis = 2.52, MValue = 2
-------------------- Histogram --------------------
[936.816 ns ;   959.243 ns) | @@@@@@@@@@@@@@@@
[959.243 ns ;   985.826 ns) | @@@
[985.826 ns ; 1,026.996 ns) | @@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=InvariantCulture]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 942.221 ns, StdErr = 3.486 ns (0.37%), N = 15, StdDev = 13.503 ns
Min = 926.351 ns, Q1 = 928.457 ns, Median = 943.452 ns, Q3 = 951.892 ns, Max = 963.705 ns
IQR = 23.435 ns, LowerFence = 893.305 ns, UpperFence = 987.044 ns
ConfidenceInterval = [927.785 ns; 956.656 ns] (CI 99.9%), Margin = 14.436 ns (1.53% of Mean)
Skewness = 0.23, Kurtosis = 1.46, MValue = 2
-------------------- Histogram --------------------
[919.165 ns ; 939.573 ns) | @@@@@@
[939.573 ns ; 970.891 ns) | @@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=Invar(...)eCase [26]]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 934.561 ns, StdErr = 1.815 ns (0.19%), N = 13, StdDev = 6.546 ns
Min = 924.874 ns, Q1 = 929.620 ns, Median = 933.981 ns, Q3 = 937.309 ns, Max = 950.674 ns
IQR = 7.689 ns, LowerFence = 918.086 ns, UpperFence = 948.843 ns
ConfidenceInterval = [926.722 ns; 942.399 ns] (CI 99.9%), Margin = 7.839 ns (0.84% of Mean)
Skewness = 0.83, Kurtosis = 3.4, MValue = 2
-------------------- Histogram --------------------
[921.221 ns ; 954.328 ns) | @@@@@@@@@@@@@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=Ordinal]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 2.126 ns, StdErr = 0.009 ns (0.42%), N = 14, StdDev = 0.034 ns
Min = 2.094 ns, Q1 = 2.100 ns, Median = 2.114 ns, Q3 = 2.141 ns, Max = 2.196 ns
IQR = 0.041 ns, LowerFence = 2.038 ns, UpperFence = 2.203 ns
ConfidenceInterval = [2.088 ns; 2.164 ns] (CI 99.9%), Margin = 0.038 ns (1.79% of Mean)
Skewness = 0.86, Kurtosis = 2.27, MValue = 2
-------------------- Histogram --------------------
[2.087 ns ; 2.170 ns) | @@@@@@@@@@@@
[2.170 ns ; 2.215 ns) | @@
---------------------------------------------------

StringComparisonBench.Bench: DefaultJob [ComparisonString=aaaa(...)aaaa [4000], Comparison=OrdinalIgnoreCase]
Runtime = .NET 6.0.9 (6.0.922.41905), X64 RyuJIT; GC = Concurrent Workstation
Mean = 1.686 ns, StdErr = 0.004 ns (0.23%), N = 12, StdDev = 0.013 ns
Min = 1.668 ns, Q1 = 1.677 ns, Median = 1.683 ns, Q3 = 1.693 ns, Max = 1.709 ns
IQR = 0.016 ns, LowerFence = 1.652 ns, UpperFence = 1.718 ns
ConfidenceInterval = [1.669 ns; 1.703 ns] (CI 99.9%), Margin = 0.017 ns (1.01% of Mean)
Skewness = 0.42, Kurtosis = 1.68, MValue = 2
-------------------- Histogram --------------------
[1.662 ns ; 1.716 ns) | @@@@@@@@@@@@
---------------------------------------------------

// * Summary *

BenchmarkDotNet=v0.13.1, OS=macOS Monterey 12.6 (21G115) [Darwin 21.6.0]
Intel Core i9-9880H CPU 2.30GHz, 1 CPU, 16 logical and 8 physical cores
.NET SDK=6.0.401
  [Host]     : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT
  DefaultJob : .NET 6.0.9 (6.0.922.41905), X64 RyuJIT
```

| Method |     ComparisonString |           Comparison |       Mean |      Error |     StdDev |     Median | Ratio | Allocated |
|------- |--------------------- |--------------------- |-----------:|-----------:|-----------:|-----------:|------:|----------:|
|  Bench |                    a |       CurrentCulture |  41.580 ns |  0.6568 ns |  0.7028 ns |  41.430 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |                    a | Curre(...)eCase [24] |  40.995 ns |  0.3170 ns |  0.2647 ns |  40.910 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |                    a |     InvariantCulture |  32.312 ns |  0.2244 ns |  0.1874 ns |  32.272 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |                    a | Invar(...)eCase [26] |  32.603 ns |  0.6497 ns |  0.6077 ns |  32.583 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |                    a |              Ordinal |   2.130 ns |  0.0316 ns |  0.0280 ns |   2.122 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |                    a |    OrdinalIgnoreCase |   1.695 ns |  0.0252 ns |  0.0223 ns |   1.688 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] |       CurrentCulture | 137.380 ns |  1.3475 ns |  1.1252 ns | 137.301 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] | Curre(...)eCase [24] | 137.460 ns |  1.4715 ns |  1.3044 ns | 137.383 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] |     InvariantCulture | 128.882 ns |  2.1730 ns |  2.0326 ns | 128.743 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] | Invar(...)eCase [26] | 128.499 ns |  1.6370 ns |  1.5312 ns | 128.098 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] |              Ordinal |   2.138 ns |  0.0447 ns |  0.0418 ns |   2.131 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench |  aaaa(...)aaaa [200] |    OrdinalIgnoreCase |   1.703 ns |  0.0489 ns |  0.0458 ns |   1.680 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] |       CurrentCulture | 500.752 ns |  9.2011 ns |  8.6067 ns | 495.684 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] | Curre(...)eCase [24] | 503.084 ns |  6.3594 ns |  5.9486 ns | 501.812 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] |     InvariantCulture | 500.396 ns | 10.0063 ns | 18.7942 ns | 492.476 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] | Invar(...)eCase [26] | 492.276 ns |  8.9593 ns |  7.4814 ns | 490.356 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] |              Ordinal |   2.148 ns |  0.0544 ns |  0.0509 ns |   2.134 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [1000] |    OrdinalIgnoreCase |   1.710 ns |  0.0582 ns |  0.0544 ns |   1.690 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] |       CurrentCulture | 935.983 ns | 14.5787 ns | 13.6369 ns | 928.240 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] | Curre(...)eCase [24] | 929.996 ns |  9.1371 ns |  8.0998 ns | 926.494 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] |     InvariantCulture | 926.260 ns |  8.7458 ns |  8.1808 ns | 925.836 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] | Invar(...)eCase [26] | 926.322 ns | 13.4243 ns | 11.9003 ns | 920.737 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] |              Ordinal |  66.129 ns |  0.8893 ns |  0.7883 ns |  66.040 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [2000] |    OrdinalIgnoreCase | 907.181 ns |  7.4666 ns |  6.6190 ns | 904.815 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] |       CurrentCulture | 946.375 ns | 12.1130 ns | 10.7379 ns | 944.922 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] | Curre(...)eCase [24] | 959.212 ns | 18.9526 ns | 24.6438 ns | 947.044 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] |     InvariantCulture | 942.221 ns | 14.4356 ns | 13.5030 ns | 943.452 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] | Invar(...)eCase [26] | 934.561 ns |  7.8385 ns |  6.5455 ns | 933.981 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] |              Ordinal |   2.126 ns |  0.0380 ns |  0.0337 ns |   2.114 ns |  1.00 |         - |
|        |                      |                      |            |            |            |            |       |           |
|  Bench | aaaa(...)aaaa [4000] |    OrdinalIgnoreCase |   1.686 ns |  0.0169 ns |  0.0132 ns |   1.683 ns |  1.00 |         - |
