using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "ushort".
    /// </summary>
    public sealed class PropertyUShort : Property<ushort>
    {
        /// <summary>
        /// Create a new ushort property.
        /// </summary>
        /// <param name="propertyValueParser">Parser helper object.</param>
        public PropertyUShort(PropertyValueParser propertyValueParser)
            : base(propertyValueParser, sizeof(ushort))
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
        public PropertyUShort(ulong structOffset, uint size, ushort value)
            : base(structOffset, size, value) { }

        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override ushort ParseValue()
        {
            var value = _propertyValueParser.Buffer.BytesToUInt16(_propertyValueParser.CurrentOffset);

            Console.WriteLine($"Read ushort {value:X2} from offset: {_propertyValueParser.CurrentOffset}");

            _propertyValueParser.CurrentOffset += sizeof(ushort);
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