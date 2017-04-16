using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageFileHeader : PEStructure, IImageFileHeader
    {
        public IProperty<ushort> Machine => new PropertyUShort(0x00, 0x0011);
        public IProperty<ushort> NumberOfSections => new PropertyUShort(0x02, 0x2233);
        public IProperty<uint> TimeDateStamp => new PropertyUInt(0x04, 0x44556677);
        public IProperty<uint> PointerToSymbolTable => new PropertyUInt(0x8, 0x8899aabb);
        public IProperty<uint> NumberOfSymbols => new PropertyUInt(0xc, 0xccddeeff);
        public IProperty<ushort> SizeOfOptionalHeader => new PropertyUShort(0x10, 0x1122);
        public IProperty<ushort> Characteristics => new PropertyUShort(0x12, 0x3344);
    }
}