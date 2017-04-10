using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "ushort[]".
    /// </summary>
    public sealed class PropertyUShortArray : Property<ushort[]>
    {
        private readonly uint _count;

        /// <summary>
        /// Create a new 
        /// </summary>
        /// <param name="propertyValueParser"></param>
        /// <param name="count"></param>
        public PropertyUShortArray(PropertyValueParser propertyValueParser, uint count) 
            : base(propertyValueParser, sizeof(ushort) * count)
        {
            _count = count;
            Value = ParseValue();
        }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyUShortArray(ulong structOffset, uint size, ushort[] value)
            : base(structOffset, size, value) { }

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
                array[i] = _propertyValueParser.Buffer.BytesToUInt16(_propertyValueParser.CurrentOffset);
                _propertyValueParser.CurrentOffset += sizeof(ushort);
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
            return RawOffset == other.RawOffset
                   && Size == other.Size
                   && Value.ListCompare(other.Value);
        }
    }
}