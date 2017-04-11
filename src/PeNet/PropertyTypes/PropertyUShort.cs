using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "ushort".
    /// </summary>
    [PropertyType(typeof(ushort))]
    public sealed class PropertyUShort : Property<ushort>
    {
        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyUShort(uint valueOffset, uint size, ushort value)
            : base(valueOffset, size, value) { }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the structure in the PE header
        /// to which the property belongs.</param>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="buffer">Buffer containing a PE structure.</param>
        public PropertyUShort(byte[] buffer, uint structOffset, uint valueOffset, uint size)
            : base(buffer, structOffset, valueOffset, size)
        {
            Value = ParseValue();
        }


        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override ushort ParseValue()
        {
            var value = _buffer.BytesToUInt16(_structOffset + ValueOffset);
            return value;
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
    }
}