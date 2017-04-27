using System;

namespace PeNet.PropertyTypes
{
    public interface IValueTypeArray<TValue> : IProperty, IEquatable<IValueTypeArray<TValue>>
        where TValue : struct
    {
        TValue[] Value { get; }
        int Count { get; }
    }
}