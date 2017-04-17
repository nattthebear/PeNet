using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageOptionalHeader32 : PEStructure, IImageOptionalHeader
    {
        public IProperty<ushort> Magic => new PropertyUShort(0x00, 0x0011);
        public IProperty<byte> MajorLinkerVersion => new PropertyByte(0x02, 0x33);
        public IProperty<byte> MinorLinkerVersion => new PropertyByte(0x03, 0x44);
        public IProperty<uint> SizeOfCode => new PropertyUInt(0x04, 0x55667788);
        public IProperty<uint> SizeOfInitializedData => new PropertyUInt(0x08, 0x99aabbcc);
        public IProperty<uint> SizeOfUninitializedData => new PropertyUInt(0x0c, 0xddeeff00);
        public IProperty<uint> AddressOfEntryPoint => new PropertyUInt(0x10, 0x11223344);
        public IProperty<uint> BaseOfCode => new PropertyUInt(0x14, 0x55667788);
        public IProperty<uint> BaseOfData => new PropertyUInt(0x18, 0x99aabbcc);
        public IProperty<ulong> ImageBase => new PropertyULong(0x1c, 4, 0xddeeff00);
        public IProperty<uint> SectionAlignment => new PropertyUInt(0x20, 0x11223344);
        public IProperty<uint> FileAlignment => new PropertyUInt(0x24, 0x55667788);
        public IProperty<ushort> MajorOperatingSystemVersion => new PropertyUShort(0x28, 0x99aa);
        public IProperty<ushort> MinorOperatingSystemVersion => new PropertyUShort(0x2a, 0xbbcc);
        public IProperty<ushort> MajorImageVersion => new PropertyUShort(0x2c, 0xddee);
        public IProperty<ushort> MinorImageVersion => new PropertyUShort(0x2e, 0xff00);
        public IProperty<ushort> MajorSubsystemVersion => new PropertyUShort(0x30, 0x1122);
        public IProperty<ushort> MinorSubsystemVersion => new PropertyUShort(0x32, 0x3344);
        public IProperty<uint> Win32VersionValue => new PropertyUInt(0x34, 0x55667788);
        public IProperty<uint> SizeOfImage => new PropertyUInt(0x38, 0x99aabbcc);
        public IProperty<uint> SizeOfHeaders => new PropertyUInt(0x3c, 0xddeeff00);
        public IProperty<uint> CheckSum => new PropertyUInt(0x40, 0x11223344);
        public IProperty<ushort> Subsystem => new PropertyUShort(0x44, 0x5566);
        public IProperty<ushort> DllCharacteristics => new PropertyUShort(0x46, 0x7788);
        public IProperty<ulong> SizeOfStackReserve => new PropertyULong(0x48, 4, 0x99aabbcc);
        public IProperty<ulong> SizeOfStackCommit => new PropertyULong(0x4c, 4, 0xddeeff00);
        public IProperty<ulong> SizeOfHeapReserve => new PropertyULong(0x50, 4, 0x11223344);
        public IProperty<ulong> SizeOfHeapCommit => new PropertyULong(0x54, 4, 0x55667788);
        public IProperty<uint> LoaderFlags => new PropertyUInt(0x58, 0x99aabbcc);
        public IProperty<uint> NumberOfRvaAndSizes => new PropertyUInt(0x5c, 0x00000004);
        public IProperty<IProperty<IImageDataDirectory>[]> DataDirectories => new PropertyDataDirectoryArray(0x60, 4*0x8, new[]
        {
            new PropertyDataDirectory(0x60, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x00112233), new PropertyUInt(0x4, 0x44556677))),
            new PropertyDataDirectory(0x68, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x8899aabb), new PropertyUInt(0x4, 0xccddeeff))),
            new PropertyDataDirectory(0x70, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x11223344), new PropertyUInt(0x4, 0x55667788))),
            new PropertyDataDirectory(0x78, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x99aabbcc), new PropertyUInt(0x4, 0xddeeff00)))
        });
    }
}