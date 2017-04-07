using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    internal sealed class PropertyUShortArray : Property<ushort[]>
    {
        private readonly uint _count;

        public PropertyUShortArray(PropertyValueParser propertyValueParser, uint count) 
            : base(propertyValueParser, sizeof(ushort) * count)
        {
            _count = count;
            Value = ParseValue();
        }

        protected override ushort[] ParseValue()
        {
            var array = new ushort[_count];
            for (var i = 0; i < _count; i++)
            {
                array[i] = _propertyValueParser.Buffer.BytesToUInt16(_propertyValueParser.CurrentOffset);
                Console.WriteLine($"Read ushort {array[i]:X2} from offset: {_propertyValueParser.CurrentOffset}");
                _propertyValueParser.CurrentOffset += sizeof(ushort);
            }
            return array;
        }

        public override bool Equals(IProperty<ushort[]> other)
        {
            return RawOffset == other.RawOffset
                   && Size == other.Size
                   && Value.ListCompare(other.Value);
        }
    }
}