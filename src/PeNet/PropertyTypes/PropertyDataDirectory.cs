using System;
using PeNet.PEStructures;
using PeNet.PEStructures.Implementation;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures,
    /// where the value is of the type "IImageDataDirectory".
    /// </summary>
    [PropertyType(typeof(IImageDataDirectory))]
    public sealed class PropertyDataDirectory : Property<IImageDataDirectory>
    {
        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">Value of the property.</param>
        public PropertyDataDirectory(uint valueOffset, uint size, IImageDataDirectory value) 
            : base(valueOffset, size, value)
        {
        }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="value">Value of the property.</param>
        public PropertyDataDirectory(uint valueOffset, IImageDataDirectory value)
            : base(valueOffset, 8, value)
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
        public PropertyDataDirectory(byte[] buffer, uint structOffset, uint valueOffset, uint size) 
            : base(buffer, structOffset, valueOffset, size)
        {
            Value = ParseValue();
        }


        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected override IImageDataDirectory ParseValue()
        {
            return new ImageDataDirectory(_buffer, _structOffset);
        }

        /// <summary>
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        public override byte[] ToBytes()
        {
            var bytes = new byte[8];
            var vaBytes = Value.VirtualAddress.Value.ToBytes();
            var sizeBytes = Value.Size.Value.ToBytes();

            Array.Copy(vaBytes, bytes, 4);
            Array.Copy(sizeBytes, 0, bytes, 4, 4);

            return bytes;
        }
    }
}