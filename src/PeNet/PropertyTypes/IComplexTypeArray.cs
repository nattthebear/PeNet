using System;

namespace PeNet.PropertyTypes
{
    public interface IComplexTypeArray<TValue> : IProperty, IEquatable<IComplexTypeArray<TValue>>
    {
        TValue[] Value { get; }
        int Count { get; }
    }
}