using PeNet.PropertyTypes;

namespace PeNet.PEStructures
{
    /// <summary>
    ///     The File header contains information about the structure
    ///     and properties of the PE file.
    /// </summary>
    public interface IImageFileHeader
    {
        /// <summary>
        ///     The machine (CPU type) the PE file is intended for.
        ///     Can be resolved with Utility.ResolveTargetMachine(machine).
        /// </summary>
        IValueType<ushort> Machine { get; }

        /// <summary>
        ///     The number of sections in the PE file.
        /// </summary>
        IValueType<ushort> NumberOfSections { get; }

        /// <summary>
        ///     Time and date stamp.
        /// </summary>
        IValueType<uint> TimeDateStamp { get; }

        /// <summary>
        ///     Pointer to COFF symbols table. They are rare in PE files,
        ///     but often in obj files.
        /// </summary>
        IValueType<uint> PointerToSymbolTable { get; }

        /// <summary>
        ///     The number of COFF symbols.
        /// </summary>
        IValueType<uint> NumberOfSymbols { get; }

        /// <summary>
        ///     The size of the optional header which follow the file header.
        /// </summary>
        IValueType<ushort> SizeOfOptionalHeader { get; }

        /// <summary>
        ///     Set of flags which describe the PE file in detail.
        ///     Can be resolved with Utility.ResolveCharacteristics(characteristics).
        /// </summary>
        IValueType<ushort> Characteristics { get; }
    }
}