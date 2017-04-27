using System;

namespace PeNet.PropertyTypes
{
    public interface IComplexType<TValue> : IProperty, IEquatable<IComplexType<TValue>>
    {
        TValue Value { get; }
    }
}