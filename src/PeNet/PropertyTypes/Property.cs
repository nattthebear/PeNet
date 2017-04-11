using System.Collections.Generic;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Represents a standard property in the header structures.
    /// </summary>
    public abstract class Property<TValue> : IProperty<TValue>
    {
        /// <summary>
        /// Buffer containing the PE header.
        /// </summary>
        protected byte[] _buffer { get; }

        /// <summary>
        /// Offset of the structure in the PE header
        /// to which the property belongs.
        /// </summary>
        protected ulong _structOffset { get; }

        /// <summary>
        /// Offset of the property in on disk.
        /// </summary>
        public uint ValueOffset { get; }

        /// <summary>
        /// Size of the value type in bytes.
        /// </summary>
        public uint Size { get; }

        /// <summary>
        /// Value of the property.
        /// </summary>
        public TValue Value { get; set; }

        /// <summary>
        /// Create a new property object.
        /// </summary>
        /// <param name="valueOffset">Offset of the value in the structure
        /// to which the property belongs.</param>
        /// <param name="size">Size of the value type in bytes.</param>
        /// <param name="value">The value of the property.</param>
        protected Property(uint valueOffset, uint size, TValue value)
        {
            Size = size;
            ValueOffset = valueOffset;
            Value = value;
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
        protected Property(byte[] buffer, uint structOffset, uint valueOffset, uint size)
        {
            Size = size;
            _buffer = buffer;
            _structOffset = structOffset;
            ValueOffset = valueOffset;
        }


        /// <summary>
        /// Parses the value from the byte 
        /// array.
        /// </summary>
        /// <returns>The property value.</returns>
        protected abstract TValue ParseValue();

        /// <summary>
        /// Serializes the property value to
        /// a byte array.
        /// </summary>
        /// <returns>Property value as a byte array.</returns>
        public abstract byte[] ToBytes();

        /// <summary>
        /// Compares if the property object
        /// is equal to another property object.
        /// </summary>
        /// <param name="other">Property object to compare with.</param>
        /// <returns>True if equal, else false.</returns>
        public virtual bool Equals(IProperty<TValue> other)
        {
            return ValueOffset == other.ValueOffset
                   && Size == other.Size
                   && Value.Equals(other.Value);
        }


        /// <summary>
        /// Compares if the property object
        /// is equal to another property object.
        /// </summary>
        /// <param name="obj">Property object to compare with.</param>
        /// <returns>True if equal, else false.</returns>
        public override bool Equals(object obj)
        {
            return Equals(obj as IProperty<TValue>);
        }

        /// <summary>
        /// Compute a hash code for the property.
        /// </summary>
        /// <returns>Hash code of the property.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = Value.GetHashCode();
                hashCode = (hashCode * 397) ^ ValueOffset.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) Size;
                hashCode = (hashCode * 397) ^ EqualityComparer<TValue>.Default.GetHashCode(Value);
                return hashCode;
            }
        }

        /// <summary>
        /// Compare the order of the property in the structure
        /// based on the offset in the PE structure.
        /// </summary>
        /// <param name="obj">An other property from the PE structure.</param>
        /// <returns>
        /// Less than zero if the first raw offset is smaller than the one of the second property.
        /// Zero if the first raw offset is equal to the one of the second property.
        /// More than zero if the first raw offset is bigger than the one of the second property.
        /// </returns>
        public int CompareTo(object obj)
        {
            var other = obj as IProperty;
            if (other == null)
                return 1;

            if (ValueOffset == other.ValueOffset)
                return 0;
            if (ValueOffset < other.ValueOffset)
                return -1;
            return 1;
        }

        /// <summary>
        /// Equality operator for the property.
        /// </summary>
        /// <param name="p1">A property.</param>
        /// <param name="p2">Another property.</param>
        /// <returns>True if the properties are equal, else false.</returns>
        public static bool operator ==(Property<TValue> p1, Property<TValue> p2)
        {
            return p1.Equals(p2);
        }

        /// <summary>
        /// Inequality operator for the property.
        /// </summary>
        /// <param name="p1">A property.</param>
        /// <param name="p2">Another property.</param>
        /// <returns>True if the properties are not equal, else false.</returns>
        public static bool operator !=(Property<TValue> p1, Property<TValue> p2)
        {
            return !p1.Equals(p2);
        }
    }
}