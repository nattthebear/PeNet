using System;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface IProperty<TValue> : IEquatable<IProperty<TValue>>
    {
        /// <summary>
        /// Offset of the property in on disk.
        /// </summary>
        ulong RawOffset { get; }

        /// <summary>
        /// Size of the value type in bytes.
        /// </summary>
        uint Size { get; }

        /// <summary>
        /// The value of the property.
        /// </summary>
        TValue Value { get; set; }
    }
}