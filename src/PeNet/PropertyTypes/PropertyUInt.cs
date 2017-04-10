using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "uint".
    /// </summary>
    public sealed class PropertyUInt : Property<uint>
    {
        /// <summary>
        /// Create a new uint property object.
        /// </summary>
        /// <param name="propertyValueParser">Parser helper object.</param>
        public PropertyUInt(PropertyValueParser propertyValueParser) 
            : base(propertyValueParser, sizeof(uint))
        {
            Value = ParseValue();
        }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyUInt(ulong structOffset, uint size, uint value)
            : base(structOffset, size, value) { }

        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override uint ParseValue()
        {
            var value = _propertyValueParser.Buffer.BytesToUInt32(_propertyValueParser.CurrentOffset);
            _propertyValueParser.CurrentOffset += sizeof(uint);
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