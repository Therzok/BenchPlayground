using System;
using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace BenchPlayground
{
    [MemoryDiagnoser]
    public class StringHashCode
    {
        public IEnumerable<StringComparerWrapper> ComparersSource => new[]
        {
            new StringComparerWrapper(StringComparer.CurrentCulture, nameof(StringComparer.CurrentCulture)),
            new StringComparerWrapper(StringComparer.CurrentCultureIgnoreCase, nameof(StringComparer.CurrentCultureIgnoreCase)),

            new StringComparerWrapper(StringComparer.InvariantCulture, nameof(StringComparer.InvariantCulture)),
            new StringComparerWrapper(StringComparer.InvariantCultureIgnoreCase, nameof(StringComparer.InvariantCultureIgnoreCase)),

            new StringComparerWrapper(StringComparer.Ordinal, nameof(StringComparer.Ordinal)),
            new StringComparerWrapper(StringComparer.OrdinalIgnoreCase, nameof(StringComparer.OrdinalIgnoreCase)),
        };

        public IEnumerable<string> HashCodeStringSource => new[]
        {
            new string('a', 1),
            new string('a', 500),
            new string('a', 1000),
        };

        [ParamsSource(nameof(HashCodeStringSource))]
        public string HashCodeString { get; set; }

        [ParamsSource(nameof(ComparersSource))]
        public StringComparerWrapper Comparer { get; set; }

        [Benchmark]
        public int Bench()
        {
            return Comparer.GetHashCode(HashCodeString);
        }

        public sealed class StringComparerWrapper
        {
            readonly string name;
            readonly StringComparer wrapped;

            public StringComparerWrapper(StringComparer wrapped, string name)
            {
                this.wrapped = wrapped;
                this.name = name;
            }

            public int GetHashCode(string value) => wrapped.GetHashCode(value);

            public override string ToString() => name;
        }
    }
}
