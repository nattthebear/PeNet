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
        IProperty<ushort> Magic { get; }

        /// <summary>
        ///     Major linker version.
        /// </summary>
        IProperty<byte> MajorLinkerVersion { get; }

        /// <summary>
        ///     Minor linker version.
        /// </summary>
        IProperty<byte> MinorLinkerVersion { get; }

        /// <summary>
        ///     Size of all code sections together.
        /// </summary>
        IProperty<uint> SizeOfCode { get; }

        /// <summary>
        ///     Size of all initialized data sections together.
        /// </summary>
        IProperty<uint> SizeOfInitializedData { get; }

        /// <summary>
        ///     Size of all uninitialized data sections together.
        /// </summary>
        IProperty<uint> SizeOfUninitializedData { get; }

        /// <summary>
        ///     RVA of the entry point function.
        /// </summary>
        IProperty<uint> AddressOfEntryPoint { get; }

        /// <summary>
        ///     RVA to the beginning of the code section.
        /// </summary>
        IProperty<uint> BaseOfCode { get; }
        /// <summary>
        ///     RVA to the beginning of the data section.
        /// </summary>
        IProperty<uint> BaseOfData { get; }

        /// <summary>
        ///     Preferred address of the image when it's loaded to memory.
        /// </summary>
        IProperty<ulong> ImageBase { get; }

        /// <summary>
        ///     Section alignment in memory in bytes. Must be greater or equal to the file alignment.
        /// </summary>
        IProperty<uint> SectionAlignment { get; }

        /// <summary>
        ///     File alignment of the raw data of the sections in bytes.
        /// </summary>
        IProperty<uint> FileAlignment { get; }

        /// <summary>
        ///     Major operation system version to run the file.
        /// </summary>
        IProperty<ushort> MajorOperatingSystemVersion { get; }

        /// <summary>
        ///     Minor operation system version to run the file.
        /// </summary>
        IProperty<ushort> MinorOperatingSystemVersion { get; }

        /// <summary>
        ///     Major image version.
        /// </summary>
        IProperty<ushort> MajorImageVersion { get; }

        /// <summary>
        ///     Minor image version.
        /// </summary>
        IProperty<ushort> MinorImageVersion { get; }

        /// <summary>
        ///     Major version of the subsystem.
        /// </summary>
        IProperty<ushort> MajorSubsystemVersion { get; }

        /// <summary>
        ///     Minor version of the subsystem.
        /// </summary>
        IProperty<ushort> MinorSubsystemVersion { get; }

        /// <summary>
        ///     Reserved and must be 0.
        /// </summary>
        IProperty<uint> Win32VersionValue { get; }

        /// <summary>
        ///     Size of the image including all headers in bytes. Must be a multiple of
        ///     the section alignment.
        /// </summary>
        IProperty<uint> SizeOfImage { get; }

        /// <summary>
        ///     Sum of the e_lfanwe from the DOS header, the 4 byte signature, size of
        ///     the file header, size of the optional header and size of all section.
        ///     Rounded to the next file alignment.
        /// </summary>
        IProperty<uint> SizeOfHeaders { get; }

        /// <summary>
        ///     Image checksum validated at runtime for drivers, DLLs loaded at boot time and
        ///     DLLs loaded into a critical system.
        /// </summary>
        IProperty<uint> CheckSum { get; }

        /// <summary>
        ///     The subsystem required to run the image e.g., Windows GUI, XBOX etc.
        ///     Can be resolved to a string with Utility.ResolveSubsystem(subsystem=
        /// </summary>
        IProperty<ushort> Subsystem { get; }

        /// <summary>
        ///     DLL characteristics of the image.
        /// </summary>
        IProperty<ushort> DllCharacteristics { get; }

        /// <summary>
        ///     Size of stack reserve in bytes.
        /// </summary>
        IProperty<ulong> SizeOfStackReserve { get; }

        /// <summary>
        ///     Size of bytes committed for the stack in bytes.
        /// </summary>
        IProperty<ulong> SizeOfStackCommit { get; }

        /// <summary>
        ///     Size of the heap to reserve in bytes.
        /// </summary>
        IProperty<ulong> SizeOfHeapReserve { get; }

        /// <summary>
        ///     Size of the heap commit in bytes.
        /// </summary>
        IProperty<ulong> SizeOfHeapCommit { get; }

        /// <summary>
        ///     Obsolete
        /// </summary>
        IProperty<uint> LoaderFlags { get; }

        /// <summary>
        ///     Number of directory entries in the remainder of the optional header.
        /// </summary>
        IProperty<uint> NumberOfRvaAndSizes { get; }
    }
}