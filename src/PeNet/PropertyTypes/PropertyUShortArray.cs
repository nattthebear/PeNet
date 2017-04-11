using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "ushort[]".
    /// </summary>
    [PropertyType(typeof(ushort[]))]
    public sealed class PropertyUShortArray : Property<ushort[]>
    {
        private readonly uint _count;

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the structure in the PE header
        /// to which the property belongs.</param>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="buffer">Buffer containing a PE structure.</param>
        public PropertyUShortArray(byte[] buffer, uint structOffset, uint valueOffset, uint size)
            : base(buffer, structOffset, valueOffset, size)
        {
            _count = size / sizeof(ushort);
            Value = ParseValue();
        }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyUShortArray(uint valueOffset, uint size, ushort[] value)
            : base(valueOffset, size, value) { }

        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override ushort[] ParseValue()
        {
            var array = new ushort[_count];
            for (var i = 0; i < _count; i++)
            {
                array[i] = _buffer.BytesToUInt16(_structOffset + ValueOffset + (ulong) i * sizeof(ushort));
            }
            return array;
        }

        /// <summary>
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        public override byte[] ToBytes()
        {
            return Value.ToBytes();
        }

        /// <summary>
        /// Compares if the property object
        /// is equal to another property object.
        /// </summary>
        /// <param name="other">Property object to compare with.</param>
        /// <returns>True if equal, else false.</returns>
        public override bool Equals(IProperty<ushort[]> other)
        {
            return ValueOffset == other.ValueOffset
                   && Size == other.Size
                   && Value.ListCompare(other.Value);
        }
    }
}