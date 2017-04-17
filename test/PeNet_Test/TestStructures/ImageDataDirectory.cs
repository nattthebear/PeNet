using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageDataDirectory : PEStructure, IImageDataDirectory
    {
        public IProperty<uint> VirtualAddress => new PropertyUInt(0x00, 0x00112233);
        public IProperty<uint> Size => new PropertyUInt(0x04, 0x44556677);
    }
}