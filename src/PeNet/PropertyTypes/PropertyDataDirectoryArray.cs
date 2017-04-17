using System;
using System.Collections.Generic;
using PeNet.PEStructures;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structure,
    /// where the value is an array of IImageDataDirectory objects.
    /// </summary>
    [PropertyType(typeof(IProperty<IImageDataDirectory>[]))]
    public sealed class PropertyDataDirectoryArray : Property<IProperty<IImageDataDirectory>[]>
    {
        private uint _numEntries;

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        public PropertyDataDirectoryArray(uint valueOffset, uint size, PropertyDataDirectory[] value) 
            : base(valueOffset, size, value)
        {
        }
        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="structOffset">Offset of the structure in the PE header
        /// to which the property belongs.</param>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="buffer">Buffer containing a PE structure.</param>
        public PropertyDataDirectoryArray(byte[] buffer, uint structOffset, uint valueOffset, uint size) 
            : base(buffer, structOffset, valueOffset, size)
        {
            _numEntries = Size / 0x8; // sizeof(ImageDataDirectory) = 0x8
            if (_numEntries > 16) // Max. 16 entries are allowed.
                _numEntries = 16;

            Value = ParseValue();
        }

        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override IProperty<IImageDataDirectory>[] ParseValue()
        {
            Value = new IProperty<IImageDataDirectory>[_numEntries];

            for (var i = 0u; i < _numEntries; i++)
            {
                Value[i] = new PropertyDataDirectory(_buffer, _structOffset, ValueOffset + i * 0x8, 0x8);
            }

            return Value;
        }

        /// <summary>
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        public override byte[] ToBytes()
        {
            var bytes = new List<byte>();
            foreach (var value in Value)
            {
                bytes.AddRange(value.ToBytes());
            }

            return bytes.ToArray();
        }

        /// <summary>
        /// Compares if the property object
        /// is equal to another property object.
        /// </summary>
        /// <param name="other">Property object to compare with.</param>
        /// <returns>True if equal, else false.</returns>
        public override bool Equals(IProperty<IProperty<IImageDataDirectory>[]> other)
        {
            if (Size != other.Size)
                return false;

            for (var i = 0; i < _numEntries; i++)
            {
                if (Value[i].Equals(other.Value[i]))
                    return false;
            }

            return true;
        }
    }
}