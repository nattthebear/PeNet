using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    internal sealed class PropertyUInt : Property<uint>
    {
        public PropertyUInt(PropertyValueParser propertyValueParser) 
            : base(propertyValueParser, sizeof(uint))
        {
            Value = ParseValue();
        }

        protected override uint ParseValue()
        {
            var value = _propertyValueParser.Buffer.BytesToUInt32(_propertyValueParser.CurrentOffset);
            _propertyValueParser.CurrentOffset += sizeof(uint);
            return value;
        }
    }
}