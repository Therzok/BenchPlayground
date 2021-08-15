using System;
using System.Collections.Generic;

namespace System
{
    public readonly struct CacheCode<T> : IEquatable<CacheCode<T>> where T:IEquatable<T>
    {
        internal readonly T _value;
        internal readonly int _hashCode;

        public CacheCode(T value, int hashCode)
        {
            _value = value;
            _hashCode = hashCode;
        }

        public bool Equals(CacheCode<T> other) => _value.Equals(other);

        public override bool Equals(object obj) => obj is CacheCode<T> other && Equals(other);

        public override int GetHashCode() => _hashCode;

        public override string ToString() => _value.ToString();
    }

    public sealed class CacheCodeEqualityComparer<T> : IEqualityComparer<CacheCode<T>> where T:IEquatable<T>
    {
        public static IEqualityComparer<CacheCode<T>> Instance { get; } = new CacheCodeEqualityComparer<T>();

        public bool Equals(CacheCode<T> x, CacheCode<T> y) => x._value.Equals(y._value);

        public int GetHashCode(CacheCode<T> obj) => obj._hashCode;
    }

    public static class HashCodeExtensions
    {
        public static CacheCode<T> CacheCode<T>(this T obj) where T:IEquatable<T>
        {
            return new CacheCode<T>(obj, obj.GetHashCode());
        }
    }
}
