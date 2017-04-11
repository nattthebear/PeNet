using System;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Attribute that describes a property of a
    /// PE header structure.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class PropertyDescription : Attribute
    {
        /// <summary>
        /// Create a new instance of a property description.
        /// </summary>
        /// <param name="valueOffset">Offset of the property in the PE
        ///     structure it belongs to.</param>
        /// <param name="valueSize">Size of the value in bytes.</param>
        public PropertyDescription(ulong valueOffset, uint valueSize)
        {
            ValueOffset = valueOffset;
            ValueSize = valueSize;
        }

        /// <summary>
        /// Offset of the property in the PE 
        /// structure it belongs to.
        /// </summary>
        public ulong ValueOffset { get; }

        /// <summary>
        /// Size of the value in bytes.
        /// </summary>
        public uint ValueSize { get; }
    }
}