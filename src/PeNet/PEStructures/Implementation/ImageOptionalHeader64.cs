using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     Represents the optional header in
    ///     the NT header.
    /// </summary>
    public class ImageOptionalHeader64 : PEStructure, IImageOptionalHeader
    {
        /// <summary>
        ///     Create a new IMAGE_OPTIONAL_HEADER 64 bit object.
        /// </summary>
        /// <param name="buff">A PE file as byte array.</param>
        /// <param name="offset">Raw offset to the file header.</param>
        public ImageOptionalHeader64(byte [] buff, uint offset)
            : base(buff, offset) { }

        /// <summary>
        ///     Flag if the file is x32, x64 or a ROM image.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x02)]
        public IProperty<ushort> Magic { get; private set; }

        /// <summary>
        ///     Major linker version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x02, valueSize: 0x01)]
        public IProperty<byte> MajorLinkerVersion { get; private set; }

        /// <summary>
        ///     Minor linker version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x03, valueSize: 0x01)]
        public IProperty<byte> MinorLinkerVersion { get; private set; }

        /// <summary>
        ///     Size of all code sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x04)]
        public IProperty<uint> SizeOfCode { get; private set; }

        /// <summary>
        ///     Size of all initialized data sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x08, valueSize: 0x04)]
        public IProperty<uint> SizeOfInitializedData { get; private set; }

        /// <summary>
        ///     Size of all uninitialized data sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0c, valueSize: 0x04)]
        public IProperty<uint> SizeOfUninitializedData { get; private set; }

        /// <summary>
        ///     RVA of the entry point function.
        /// </summary>
        [PropertyDescription(valueOffset: 0x10, valueSize: 0x04)]
        public IProperty<uint> AddressOfEntryPoint { get; private set; }

        /// <summary>
        ///     RVA to the beginning of the code section.
        /// </summary>
        [PropertyDescription(valueOffset: 0x14, valueSize: 0x04)]
        public IProperty<uint> BaseOfCode { get; private set; }

        /// <summary>
        ///     Does not exit in x64 optional header.
        /// </summary>
        public IProperty<uint> BaseOfData { get; private set; }

        /// <summary>
        ///     Preferred address of the image when it's loaded to memory.
        /// </summary>
        [PropertyDescription(valueOffset: 0x18, valueSize: 0x08)]
        public IProperty<ulong> ImageBase { get; private set; }

        /// <summary>
        ///     Section alignment in memory in bytes. Must be greater or equal to the file alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x20, valueSize: 0x04)]
        public IProperty<uint> SectionAlignment { get; private set; }

        /// <summary>
        ///     File alignment of the raw data of the sections in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x24, valueSize: 0x04)]
        public IProperty<uint> FileAlignment { get; private set; }

        /// <summary>
        ///     Major operation system version to run the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x28, valueSize: 0x02)]
        public IProperty<ushort> MajorOperatingSystemVersion { get; private set; }

        /// <summary>
        ///     Minor operation system version to run the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2a, valueSize: 0x02)]
        public IProperty<ushort> MinorOperatingSystemVersion { get; private set; }

        /// <summary>
        ///     Major image version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2c, valueSize: 0x02)]
        public IProperty<ushort> MajorImageVersion { get; private set; }

        /// <summary>
        ///     Minor image version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2e, valueSize: 0x02)]
        public IProperty<ushort> MinorImageVersion { get; private set; }

        /// <summary>
        ///     Major version of the subsystem.
        /// </summary>
        [PropertyDescription(valueOffset: 0x30, valueSize: 0x02)]
        public IProperty<ushort> MajorSubsystemVersion { get; private set; }

        /// <summary>
        ///     Minor version of the subsystem.
        /// </summary>
        [PropertyDescription(valueOffset: 0x32, valueSize: 0x02)]
        public IProperty<ushort> MinorSubsystemVersion { get; private set; }

        /// <summary>
        ///     Reserved and must be 0.
        /// </summary>
        [PropertyDescription(valueOffset: 0x34, valueSize: 0x04)]
        public IProperty<uint> Win32VersionValue { get; private set; }

        /// <summary>
        ///     Size of the image including all headers in bytes. Must be a multiple of
        ///     the section alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x38, valueSize: 0x04)]
        public IProperty<uint> SizeOfImage { get; private set; }

        /// <summary>
        ///     Sum of the e_lfanwe from the DOS header, the 4 byte signature, size of
        ///     the file header, size of the optional header and size of all section.
        ///     Rounded to the next file alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x3c, valueSize: 0x04)]
        public IProperty<uint> SizeOfHeaders { get; private set; }

        /// <summary>
        ///     Image checksum validated at runtime for drivers, DLLs loaded at boot time and
        ///     DLLs loaded into a critical system.
        /// </summary>
        [PropertyDescription(valueOffset: 0x40, valueSize: 0x04)]
        public IProperty<uint> CheckSum { get; private set; }

        /// <summary>
        ///     The subsystem required to run the image e.g., Windows GUI, XBOX etc.
        ///     Can be resolved to a string with Utility.ResolveSubsystem(subsystem=
        /// </summary>
        [PropertyDescription(valueOffset: 0x44, valueSize: 0x02)]
        public IProperty<ushort> Subsystem { get; private set; }

        /// <summary>
        ///     DLL characteristics of the image.
        /// </summary>
        [PropertyDescription(valueOffset: 0x46, valueSize: 0x02)]
        public IProperty<ushort> DllCharacteristics { get; private set; }

        /// <summary>
        ///     Size of stack reserve in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x48, valueSize: 0x08)]
        public IProperty<ulong> SizeOfStackReserve { get; private set; }

        /// <summary>
        ///     Size of bytes committed for the stack in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x50, valueSize: 0x08)]
        public IProperty<ulong> SizeOfStackCommit { get; private set; }

        /// <summary>
        ///     Size of the heap to reserve in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x58, valueSize: 0x08)]
        public IProperty<ulong> SizeOfHeapReserve { get; private set; }

        /// <summary>
        ///     Size of the heap commit in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x60, valueSize: 0x08)]
        public IProperty<ulong> SizeOfHeapCommit { get; private set; }

        /// <summary>
        ///     Obsolete
        /// </summary>
        [PropertyDescription(valueOffset: 0x68, valueSize: 0x04)]
        public IProperty<uint> LoaderFlags { get; private set; }

        /// <summary>
        ///     Number of directory entries in the remainder of the optional header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x6c, valueSize: 0x04)]
        public IProperty<uint> NumberOfRvaAndSizes { get; private set; }
    }
}