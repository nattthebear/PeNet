using System;
using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    internal sealed class PropertyUShort : Property<ushort>
    {
        public PropertyUShort(PropertyValueParser propertyValueParser)
            : base(propertyValueParser, sizeof(ushort))
        {
            Value = ParseValue();
        }

        protected override ushort ParseValue()
        {
            var value = _propertyValueParser.Buffer.BytesToUInt16(_propertyValueParser.CurrentOffset);

            Console.WriteLine($"Read ushort {value:X2} from offset: {_propertyValueParser.CurrentOffset}");

            _propertyValueParser.CurrentOffset += sizeof(ushort);
            return value;
        }
    }
}