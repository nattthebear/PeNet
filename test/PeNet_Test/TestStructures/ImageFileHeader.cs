using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageFileHeader : PEStructure, IImageFileHeader
    {
        public IValueType<ushort> Machine => new PropertyUShort(0x00, 0x0011);
        public IValueType<ushort> NumberOfSections => new PropertyUShort(0x02, 0x2233);
        public IValueType<uint> TimeDateStamp => new PropertyUInt(0x04, 0x44556677);
        public IValueType<uint> PointerToSymbolTable => new PropertyUInt(0x8, 0x8899aabb);
        public IValueType<uint> NumberOfSymbols => new PropertyUInt(0xc, 0xccddeeff);
        public IValueType<ushort> SizeOfOptionalHeader => new PropertyUShort(0x10, 0x1122);
        public IValueType<ushort> Characteristics => new PropertyUShort(0x12, 0x3344);
    }
}