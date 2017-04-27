using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     The File header contains information about the structure
    ///     and properties of the PE file.
    /// </summary>
    public class ImageFileHeader : IImageFileHeader
    {
        /// <summary>
        ///     The machine (CPU type) the PE file is intended for.
        ///     Can be resolved with Utility.ResolveTargetMachine(machine).
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x02)]
        public IValueType<ushort> Machine { get; private set; }

        /// <summary>
        ///     The number of sections in the PE file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x02, valueSize: 0x02)]
        public IValueType<ushort> NumberOfSections { get; private set; }

        /// <summary>
        ///     Time and date stamp.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x04)]
        public IValueType<uint> TimeDateStamp { get; private set; }

        /// <summary>
        ///     Pointer to COFF symbols table. They are rare in PE files,
        ///     but often in obj files.
        /// </summary>
        [PropertyDescription(valueOffset: 0x08, valueSize: 0x04)]
        public IValueType<uint> PointerToSymbolTable { get; private set; }

        /// <summary>
        ///     The number of COFF symbols.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0c, valueSize: 0x04)]
        public IValueType<uint> NumberOfSymbols { get; private set; }

        /// <summary>
        ///     The size of the optional header which follow the file header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x10, valueSize: 0x02)]
        public IValueType<ushort> SizeOfOptionalHeader { get; private set; }

        /// <summary>
        ///     Set of flags which describe the PE file in detail.
        ///     Can be resolved with Utility.ResolveCharacteristics(characteristics).
        /// </summary>
        [PropertyDescription(valueOffset: 0x12, valueSize: 0x02)]
        public IValueType<ushort> Characteristics { get; private set; }
    }
}