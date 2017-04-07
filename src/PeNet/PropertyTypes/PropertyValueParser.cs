using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    internal class PropertyValueParser
    {
        public readonly byte[] Buffer;
        public uint CurrentOffset { get; internal set; }
       
        public PropertyValueParser(byte[] buffer, uint startOffset)
        {
            Buffer = buffer;
            CurrentOffset = startOffset;
        }
    }
}