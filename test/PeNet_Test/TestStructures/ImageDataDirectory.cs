using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageDataDirectory : IImageDataDirectory
    {
        public IValueType<uint> VirtualAddress => new ValueType<uint>(0x00, sizeof(uint), 0x00112233);
        public IValueType<uint> Size => new ValueType<uint>(0x04, sizeof(uint), 0x44556677);
    }
}