using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "ulong".
    /// </summary>
    [PropertyType(typeof(ulong))]
    public class PropertyULong : Property<ulong>
    {
        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyULong(uint valueOffset, uint size, ulong value)
            : base(valueOffset, size, value) { }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyULong(uint valueOffset, ulong value)
            : base(valueOffset, sizeof(ulong), value) { }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the structure in the PE header
        /// to which the property belongs.</param>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="buffer">Buffer containing a PE structure.</param>
        public PropertyULong(byte[] buffer, uint structOffset, uint valueOffset, uint size)
            : base(buffer, structOffset, valueOffset, size)
        {
            Value = ParseValue();
        }


        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override ulong ParseValue()
        {
            var value = _buffer.BytesToUInt64(_structOffset + ValueOffset, Size);
            return value;
        }

        /// <summary>
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        public override byte[] ToBytes()
        {
            // Special case for x32 values.
            if (Size == sizeof(uint))
                return ((uint) Value).ToBytes();

            return Value.ToBytes();
        }
    }
}