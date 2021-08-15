using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [GenericTypeArguments(typeof(int))]
    [GenericTypeArguments(typeof(TimeSpan))]
    [GenericTypeArguments(typeof(string))]
    public class CacheCodeBench<T> where T:IEquatable<T>
    {
        public T[] ValueArray
        {
            get
            {
                if (typeof(T) == typeof(int))
                    return (T[])(object)new[] { 0, byte.MaxValue, short.MaxValue };

                if (typeof(T) == typeof(TimeSpan))
                    return (T[])(object)new[] { TimeSpan.Zero, TimeSpan.FromHours(2), TimeSpan.FromDays(2) };

                if (typeof(T) == typeof(string))
                    return (T[])(object)new[] {
                        string.Join("", Enumerable.Repeat("asdf", 100)),
                        string.Join("", Enumerable.Repeat("ASDF", 100)),
                        string.Join("", Enumerable.Repeat("aSdF", 100)),
                    };

                throw new NotImplementedException();
            }
        }

        public IEnumerable<T> ValuesSource => ValueArray;

        [Benchmark(Baseline = true)]
        [ArgumentsSource(nameof(ValuesSource))]
        public Dictionary<T, int> LoopUncache(T value)
        {
            var dictionary = new Dictionary<T, int>();

            dictionary.Add(value, 0);
            dictionary[value] = 1;
            dictionary.Remove(value);
            return dictionary;
        }

        [Benchmark]
        [ArgumentsSource(nameof(ValuesSource))]
        public Dictionary<CacheCode<T>, int> LoopCache(T nocache)
        {
            var dictionary = new Dictionary<CacheCode<T>, int>();
            var value = nocache.CacheCode();

            dictionary.Add(value, 0);
            dictionary[value] = 1;
            dictionary.Remove(value);
            return dictionary;
        }

        [Benchmark]
        [ArgumentsSource(nameof(ValuesSource))]
        public Dictionary<CacheCode<T>, int> LoopCacheEq(T nocache)
        {
            var dictionary = new Dictionary<CacheCode<T>, int>(CacheCodeEqualityComparer<T>.Instance);
            var value = nocache.CacheCode();

            dictionary.Add(value, 0);
            dictionary[value] = 1;
            dictionary.Remove(value);
            return dictionary;
        }
    }
}
