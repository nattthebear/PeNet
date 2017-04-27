using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     Represents the optional header in
    ///     the NT header.
    /// </summary>
    public class ImageOptionalHeader32 : IImageOptionalHeader
    {
        /// <summary>
        ///     Flag if the file is x32, x64 or a ROM image.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x02)]
        public IValueType<ushort> Magic { get; private set; }

        /// <summary>
        ///     Major linker version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x02, valueSize: 0x01)]
        public IValueType<byte> MajorLinkerVersion { get; private set; }

        /// <summary>
        ///     Minor linker version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x03, valueSize: 0x01)]
        public IValueType<byte> MinorLinkerVersion { get; private set; }

        /// <summary>
        ///     Size of all code sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x04)]
        public IValueType<uint> SizeOfCode { get; private set; }

        /// <summary>
        ///     Size of all initialized data sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x08, valueSize: 0x04)]
        public IValueType<uint> SizeOfInitializedData { get; private set; }

        /// <summary>
        ///     Size of all uninitialized data sections together.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0c, valueSize: 0x04)]
        public IValueType<uint> SizeOfUninitializedData { get; private set; }

        /// <summary>
        ///     RVA of the entry point function.
        /// </summary>
        [PropertyDescription(valueOffset: 0x10, valueSize: 0x04)]
        public IValueType<uint> AddressOfEntryPoint { get; private set; }

        /// <summary>
        ///     RVA to the beginning of the code section.
        /// </summary>
        [PropertyDescription(valueOffset: 0x14, valueSize: 0x04)]
        public IValueType<uint> BaseOfCode { get; private set; }

        /// <summary>
        ///     RVA to the beginning of the data section.
        /// </summary>
        [PropertyDescription(valueOffset: 0x18, valueSize: 0x04)]
        public IValueType<uint> BaseOfData { get; private set; }

        /// <summary>
        ///     Preferred address of the image when it's loaded to memory.
        /// </summary>
        [PropertyDescription(valueOffset: 0x1c, valueSize: 0x04)]
        public IValueType<ulong> ImageBase { get; private set; }

        /// <summary>
        ///     Section alignment in memory in bytes. Must be greater or equal to the file alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x20, valueSize: 0x04)]
        public IValueType<uint> SectionAlignment { get; private set; }

        /// <summary>
        ///     File alignment of the raw data of the sections in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x24, valueSize: 0x04)]
        public IValueType<uint> FileAlignment { get; private set; }

        /// <summary>
        ///     Major operation system version to run the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x28, valueSize: 0x02)]
        public IValueType<ushort> MajorOperatingSystemVersion { get; private set; }

        /// <summary>
        ///     Minor operation system version to run the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2a, valueSize: 0x02)]
        public IValueType<ushort> MinorOperatingSystemVersion { get; private set; }

        /// <summary>
        ///     Major image version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2c, valueSize: 0x02)]
        public IValueType<ushort> MajorImageVersion { get; private set; }

        /// <summary>
        ///     Minor image version.
        /// </summary>
        [PropertyDescription(valueOffset: 0x2e, valueSize: 0x02)]
        public IValueType<ushort> MinorImageVersion { get; private set; }

        /// <summary>
        ///     Major version of the subsystem.
        /// </summary>
        [PropertyDescription(valueOffset: 0x30, valueSize: 0x02)]
        public IValueType<ushort> MajorSubsystemVersion { get; private set; }

        /// <summary>
        ///     Minor version of the subsystem.
        /// </summary>
        [PropertyDescription(valueOffset: 0x32, valueSize: 0x02)]
        public IValueType<ushort> MinorSubsystemVersion { get; private set; }

        /// <summary>
        ///     Reserved and must be 0.
        /// </summary>
        [PropertyDescription(valueOffset: 0x34, valueSize: 0x04)]
        public IValueType<uint> Win32VersionValue { get; private set; }

        /// <summary>
        ///     Size of the image including all headers in bytes. Must be a multiple of
        ///     the section alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x38, valueSize: 0x04)]
        public IValueType<uint> SizeOfImage { get; private set; }

        /// <summary>
        ///     Sum of the e_lfanwe from the DOS header, the 4 byte signature, size of
        ///     the file header, size of the optional header and size of all section.
        ///     Rounded to the next file alignment.
        /// </summary>
        [PropertyDescription(valueOffset: 0x3c, valueSize: 0x04)]
        public IValueType<uint> SizeOfHeaders { get; private set; }

        /// <summary>
        ///     Image checksum validated at runtime for drivers, DLLs loaded at boot time and
        ///     DLLs loaded into a critical system.
        /// </summary>
        [PropertyDescription(valueOffset: 0x40, valueSize: 0x04)]
        public IValueType<uint> CheckSum { get; private set; }

        /// <summary>
        ///     The subsystem required to run the image e.g., Windows GUI, XBOX etc.
        ///     Can be resolved to a string with Utility.ResolveSubsystem(subsystem=
        /// </summary>
        [PropertyDescription(valueOffset: 0x44, valueSize: 0x02)]
        public IValueType<ushort> Subsystem { get; private set; }

        /// <summary>
        ///     DLL characteristics of the image.
        /// </summary>
        [PropertyDescription(valueOffset: 0x46, valueSize: 0x02)]
        public IValueType<ushort> DllCharacteristics { get; private set; }

        /// <summary>
        ///     Size of stack reserve in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x48, valueSize: 0x04)]
        public IValueType<ulong> SizeOfStackReserve { get; private set; }

        /// <summary>
        ///     Size of bytes committed for the stack in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x4c, valueSize: 0x04)]
        public IValueType<ulong> SizeOfStackCommit { get; private set; }

        /// <summary>
        ///     Size of the heap to reserve in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x50, valueSize: 0x04)]
        public IValueType<ulong> SizeOfHeapReserve { get; private set; }

        /// <summary>
        ///     Size of the heap commit in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x54, valueSize: 0x04)]
        public IValueType<ulong> SizeOfHeapCommit { get; private set; }

        /// <summary>
        ///     Obsolete
        /// </summary>
        [PropertyDescription(valueOffset: 0x58, valueSize: 0x04)]
        public IValueType<uint> LoaderFlags { get; private set; }

        /// <summary>
        ///     Number of directory entries in the remainder of the optional header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x5c, valueSize: 0x04)]
        public IValueType<uint> NumberOfRvaAndSizes { get; private set; }

        /// <summary>
        ///     Array of data directory structures. At most 16 entries.
        /// </summary>
        public IComplexTypeArray<IComplexType<IImageDataDirectory>> DataDirectories { get; private set; }
    }
}