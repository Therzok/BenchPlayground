using System;
using System.Collections.Generic;

namespace System
{
    public readonly struct CacheCode<T> : IEquatable<CacheCode<T>>, IEquatable<T> where T:IEquatable<T>
    {
        internal readonly T _value;
        internal readonly int _hashCode;
        internal readonly IEqualityComparer<T>? _equalityComparer;

        public CacheCode(T value) : this(value, null)
        {
        }

        public CacheCode(T value, IEqualityComparer<T>? comparer)
        {
            _value = value;
            _equalityComparer = comparer;

            _hashCode = _equalityComparer?.GetHashCode(value) ?? value?.GetHashCode() ?? 0;
        }

        public bool Equals(T other) => _equalityComparer != null ? _equalityComparer.Equals(other) : _value.Equals(other);

        public bool Equals(CacheCode<T> other) => Equals(other._value);

        public override bool Equals(object obj)
        {
            return obj switch
            {
                CacheCode<T> cc => Equals(cc._value),
                T c => Equals(c),
                _ => false,
            };
        }

        public override int GetHashCode() => _hashCode;

        public override string ToString() => _value.ToString();
    }

    public static class HashCodeExtensions
    {
        public static CacheCode<T> CacheCode<T>(this T obj) where T : IEquatable<T>
        {
            return new CacheCode<T>(obj, null);
        }

        public static CacheCode<T> CacheCode<T>(this T obj, IEqualityComparer<T> comparer) where T:IEquatable<T>
        {
            return new CacheCode<T>(obj, comparer);
        }
    }
}
