using System;
using System.Collections;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface IValueType<TValue> : IProperty, IEquatable<IValueType<TValue>>
        where TValue: struct
    {
        /// <summary>
        /// The value of the property.
        /// </summary>
        TValue Value { get; set; }
    }
}