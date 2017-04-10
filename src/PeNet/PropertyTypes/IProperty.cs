using System;

namespace PeNet.PropertyTypes
{

    /// <summary>
    /// Represents a standard property in the header structures.
    /// </summary>
    public interface IProperty: IComparable
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
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        byte[] ToBytes();
    }


    /// <summary>
    /// Represents a standard property in the header structures.
    /// </summary>
    /// <typeparam name="TValue"></typeparam>
    public interface IProperty<TValue> : IProperty, IEquatable<IProperty<TValue>>
    {
        /// <summary>
        /// The value of the property.
        /// </summary>
        TValue Value { get; set; }
    }
}