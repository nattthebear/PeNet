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
        IProperty<ushort> Machine { get; }

        /// <summary>
        ///     The number of sections in the PE file.
        /// </summary>
        IProperty<ushort> NumberOfSections { get; }

        /// <summary>
        ///     Time and date stamp.
        /// </summary>
        IProperty<uint> TimeDateStamp { get; }

        /// <summary>
        ///     Pointer to COFF symbols table. They are rare in PE files,
        ///     but often in obj files.
        /// </summary>
        IProperty<uint> PointerToSymbolTable { get; }

        /// <summary>
        ///     The number of COFF symbols.
        /// </summary>
        IProperty<uint> NumberOfSymbols { get; }

        /// <summary>
        ///     The size of the optional header which follow the file header.
        /// </summary>
        IProperty<ushort> SizeOfOptionalHeader { get; }

        /// <summary>
        ///     Set of flags which describe the PE file in detail.
        ///     Can be resolved with Utility.ResolveCharacteristics(characteristics).
        /// </summary>
        IProperty<ushort> Characteristics { get; }

        /// <summary>
        ///     Creates a string representation of all object properties.
        /// </summary>
        /// <returns>The file header properties as a string.</returns>
        string ToString();
    }
}