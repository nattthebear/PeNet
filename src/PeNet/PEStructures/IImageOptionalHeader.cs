using PeNet.PropertyTypes;

namespace PeNet.PEStructures
{
    /// <summary>
    ///     Represents the optional header in
    ///     the NT header.
    /// </summary>
    public interface IImageOptionalHeader
    {
        /// <summary>
        ///     Flag if the file is x32, x64 or a ROM image.
        /// </summary>
        IValueType<ushort> Magic { get; }

        /// <summary>
        ///     Major linker version.
        /// </summary>
        IValueType<byte> MajorLinkerVersion { get; }

        /// <summary>
        ///     Minor linker version.
        /// </summary>
        IValueType<byte> MinorLinkerVersion { get; }

        /// <summary>
        ///     Size of all code sections together.
        /// </summary>
        IValueType<uint> SizeOfCode { get; }

        /// <summary>
        ///     Size of all initialized data sections together.
        /// </summary>
        IValueType<uint> SizeOfInitializedData { get; }

        /// <summary>
        ///     Size of all uninitialized data sections together.
        /// </summary>
        IValueType<uint> SizeOfUninitializedData { get; }

        /// <summary>
        ///     RVA of the entry point function.
        /// </summary>
        IValueType<uint> AddressOfEntryPoint { get; }

        /// <summary>
        ///     RVA to the beginning of the code section.
        /// </summary>
        IValueType<uint> BaseOfCode { get; }
        /// <summary>
        ///     RVA to the beginning of the data section.
        /// </summary>
        IValueType<uint> BaseOfData { get; }

        /// <summary>
        ///     Preferred address of the image when it's loaded to memory.
        /// </summary>
        IValueType<ulong> ImageBase { get; }

        /// <summary>
        ///     Section alignment in memory in bytes. Must be greater or equal to the file alignment.
        /// </summary>
        IValueType<uint> SectionAlignment { get; }

        /// <summary>
        ///     File alignment of the raw data of the sections in bytes.
        /// </summary>
        IValueType<uint> FileAlignment { get; }

        /// <summary>
        ///     Major operation system version to run the file.
        /// </summary>
        IValueType<ushort> MajorOperatingSystemVersion { get; }

        /// <summary>
        ///     Minor operation system version to run the file.
        /// </summary>
        IValueType<ushort> MinorOperatingSystemVersion { get; }

        /// <summary>
        ///     Major image version.
        /// </summary>
        IValueType<ushort> MajorImageVersion { get; }

        /// <summary>
        ///     Minor image version.
        /// </summary>
        IValueType<ushort> MinorImageVersion { get; }

        /// <summary>
        ///     Major version of the subsystem.
        /// </summary>
        IValueType<ushort> MajorSubsystemVersion { get; }

        /// <summary>
        ///     Minor version of the subsystem.
        /// </summary>
        IValueType<ushort> MinorSubsystemVersion { get; }

        /// <summary>
        ///     Reserved and must be 0.
        /// </summary>
        IValueType<uint> Win32VersionValue { get; }

        /// <summary>
        ///     Size of the image including all headers in bytes. Must be a multiple of
        ///     the section alignment.
        /// </summary>
        IValueType<uint> SizeOfImage { get; }

        /// <summary>
        ///     Sum of the e_lfanwe from the DOS header, the 4 byte signature, size of
        ///     the file header, size of the optional header and size of all section.
        ///     Rounded to the next file alignment.
        /// </summary>
        IValueType<uint> SizeOfHeaders { get; }

        /// <summary>
        ///     Image checksum validated at runtime for drivers, DLLs loaded at boot time and
        ///     DLLs loaded into a critical system.
        /// </summary>
        IValueType<uint> CheckSum { get; }

        /// <summary>
        ///     The subsystem required to run the image e.g., Windows GUI, XBOX etc.
        ///     Can be resolved to a string with Utility.ResolveSubsystem(subsystem=
        /// </summary>
        IValueType<ushort> Subsystem { get; }

        /// <summary>
        ///     DLL characteristics of the image.
        /// </summary>
        IValueType<ushort> DllCharacteristics { get; }

        /// <summary>
        ///     Size of stack reserve in bytes.
        /// </summary>
        IValueType<ulong> SizeOfStackReserve { get; }

        /// <summary>
        ///     Size of bytes committed for the stack in bytes.
        /// </summary>
        IValueType<ulong> SizeOfStackCommit { get; }

        /// <summary>
        ///     Size of the heap to reserve in bytes.
        /// </summary>
        IValueType<ulong> SizeOfHeapReserve { get; }

        /// <summary>
        ///     Size of the heap commit in bytes.
        /// </summary>
        IValueType<ulong> SizeOfHeapCommit { get; }

        /// <summary>
        ///     Obsolete
        /// </summary>
        IValueType<uint> LoaderFlags { get; }

        /// <summary>
        ///     Number of directory entries in the remainder of the optional header.
        /// </summary>
        IValueType<uint> NumberOfRvaAndSizes { get; }

        /// <summary>
        ///     Array of data directories. Num. of data directories must be smaller or 
        ///     equal to 16.
        /// </summary>
        IComplexTypeArray<IComplexType<IImageDataDirectory>> DataDirectories { get; }
    }
}