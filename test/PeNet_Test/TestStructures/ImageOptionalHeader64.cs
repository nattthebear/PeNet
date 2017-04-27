using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageOptionalHeader64 : PEStructure, IImageOptionalHeader
    {
        public IValueType<ushort> Magic => new PropertyUShort(0x00, 0x0011);
        public IValueType<byte> MajorLinkerVersion => new PropertyByte(0x02, 0x33);
        public IValueType<byte> MinorLinkerVersion => new PropertyByte(0x03, 0x44);
        public IValueType<uint> SizeOfCode => new PropertyUInt(0x04, 0x55667788);
        public IValueType<uint> SizeOfInitializedData => new PropertyUInt(0x08, 0x99aabbcc);
        public IValueType<uint> SizeOfUninitializedData => new PropertyUInt(0x0c, 0xddeeff00);
        public IValueType<uint> AddressOfEntryPoint => new PropertyUInt(0x10, 0x11223344);
        public IValueType<uint> BaseOfCode => new PropertyUInt(0x14, 0x55667788);
        public IValueType<uint> BaseOfData => null; // Does not exist in x64 header.
        public IValueType<ulong> ImageBase => new PropertyULong(0x18, 0xddeeff00);
        public IValueType<uint> SectionAlignment => new PropertyUInt(0x20, 0x11223344);
        public IValueType<uint> FileAlignment => new PropertyUInt(0x24, 0x55667788);
        public IValueType<ushort> MajorOperatingSystemVersion => new PropertyUShort(0x28, 0x99aa);
        public IValueType<ushort> MinorOperatingSystemVersion => new PropertyUShort(0x2a, 0xbbcc);
        public IValueType<ushort> MajorImageVersion => new PropertyUShort(0x2c, 0xddee);
        public IValueType<ushort> MinorImageVersion => new PropertyUShort(0x2e, 0xff00);
        public IValueType<ushort> MajorSubsystemVersion => new PropertyUShort(0x30, 0x1122);
        public IValueType<ushort> MinorSubsystemVersion => new PropertyUShort(0x32, 0x3344);
        public IValueType<uint> Win32VersionValue => new PropertyUInt(0x34, 0x55667788);
        public IValueType<uint> SizeOfImage => new PropertyUInt(0x38, 0x99aabbcc);
        public IValueType<uint> SizeOfHeaders => new PropertyUInt(0x3c, 0xddeeff00);
        public IValueType<uint> CheckSum => new PropertyUInt(0x40, 0x11223344);
        public IValueType<ushort> Subsystem => new PropertyUShort(0x44, 0x5566);
        public IValueType<ushort> DllCharacteristics => new PropertyUShort(0x46, 0x7788);
        public IValueType<ulong> SizeOfStackReserve => new PropertyULong(0x48, 0x99aabbcc);
        public IValueType<ulong> SizeOfStackCommit => new PropertyULong(0x50, 0xddeeff00);
        public IValueType<ulong> SizeOfHeapReserve => new PropertyULong(0x58, 0x11223344);
        public IValueType<ulong> SizeOfHeapCommit => new PropertyULong(0x60, 0x55667788);
        public IValueType<uint> LoaderFlags => new PropertyUInt(0x68, 0x99aabbcc);
        public IValueType<uint> NumberOfRvaAndSizes => new PropertyUInt(0x6c, 0x00000004);
        public IValueType<IValueType<IImageDataDirectory>[]> DataDirectories => new PropertyDataDirectoryArray(0x70, 4 * 0x8, new[]
        {
            new PropertyDataDirectory(0x70, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x00112233), new PropertyUInt(0x4, 0x44556677))),
            new PropertyDataDirectory(0x78, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x8899aabb), new PropertyUInt(0x4, 0xccddeeff))),
            new PropertyDataDirectory(0x80, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x11223344), new PropertyUInt(0x4, 0x55667788))),
            new PropertyDataDirectory(0x88, new PeNet.PEStructures.Implementation.ImageDataDirectory(new PropertyUInt(0x0, 0x99aabbcc), new PropertyUInt(0x4, 0xddeeff00)))
        });
    }
}