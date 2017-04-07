using System;
using System.Collections;
using System.Collections.Generic;

namespace PeNet.PropertyTypes
{
    internal abstract class Property<TValue> : IProperty<TValue>
    {
        protected readonly PropertyValueParser _propertyValueParser;
        public ulong RawOffset { get; }
        public uint Size { get; }
        public TValue Value { get; set; }

        protected Property(PropertyValueParser propertyValueParser, uint size)
        {
            _propertyValueParser = propertyValueParser;
            Size = size;
            RawOffset = _propertyValueParser.CurrentOffset;
        }

        protected abstract TValue ParseValue();


        public virtual bool Equals(IProperty<TValue> other)
        {
            return RawOffset == other.RawOffset
                   && Size == other.Size
                   && Value.Equals(other.Value);
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as IProperty<TValue>);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (_propertyValueParser != null ? _propertyValueParser.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ RawOffset.GetHashCode();
                hashCode = (hashCode * 397) ^ (int) Size;
                hashCode = (hashCode * 397) ^ EqualityComparer<TValue>.Default.GetHashCode(Value);
                return hashCode;
            }
        }

        public static bool operator ==(Property<TValue> p1, Property<TValue> p2)
        {
            return p1.Equals(p2);
        }

        public static bool operator !=(Property<TValue> p1, Property<TValue> p2)
        {
            return !p1.Equals(p2);
        }
    }
}