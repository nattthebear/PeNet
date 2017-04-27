using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     The IMAGE_DOS_HEADER with which every PE file starts.
    /// </summary>
    public class ImageDosHeader : IImageDosHeader
    {
        /// <summary>
        ///     Magic "MZ" header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x02)]
        public IValueType<ushort> e_magic { get; private set; }

        /// <summary>
        ///     Bytes on the last page of the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x02, valueSize: 0x02)]
        public IValueType<ushort> e_cblp { get; private set; }

        /// <summary>
        ///     Pages in the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x02)]
        public IValueType<ushort> e_cp { get; private set; }

        /// <summary>
        ///     Relocations.
        /// </summary>
        [PropertyDescription(valueOffset: 0x06, valueSize: 0x02)]
        public IValueType<ushort> e_crlc { get; private set; }

        /// <summary>
        ///     Size of the header in paragraphs.
        /// </summary>
        [PropertyDescription(valueOffset: 0x08, valueSize: 0x02)]
        public IValueType<ushort> e_cparhdr { get; private set; }


        /// <summary>
        ///     Minimum extra paragraphs needed.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0a, valueSize: 0x02)]
        public IValueType<ushort> e_minalloc { get; private set; }

        /// <summary>
        ///     Maximum extra paragraphs needed.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0c, valueSize: 0x02)]
        public IValueType<ushort> e_maxalloc { get; private set; }


        /// <summary>
        ///     Initial (relative) SS value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0e, valueSize: 0x02)]
        public IValueType<ushort> e_ss { get; private set; }


        /// <summary>
        ///     Initial SP value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x10, valueSize: 0x02)]
        public IValueType<ushort> e_sp { get; private set; }

        /// <summary>
        ///     Checksum
        /// </summary>
        [PropertyDescription(valueOffset: 0x12, valueSize: 0x02)]
        public IValueType<ushort> e_csum { get; private set; }

        /// <summary>
        ///     Initial IP value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x14, valueSize: 0x02)]
        public IValueType<ushort> e_ip { get; private set; }

        /// <summary>
        ///     Initial (relative) CS value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x16, valueSize: 0x02)]
        public IValueType<ushort> e_cs { get; private set; }

        /// <summary>
        ///     Raw address of the relocation table.
        /// </summary>
        [PropertyDescription(valueOffset: 0x18, valueSize: 0x02)]
        public IValueType<ushort> e_lfarlc { get; private set; }

        /// <summary>
        ///     Overlay number.
        /// </summary>
        [PropertyDescription(valueOffset: 0x1a, valueSize: 0x02)]
        public IValueType<ushort> e_ovno { get; private set; }

        /// <summary>
        ///     Reserved. Consists of 4 * UInt16.
        /// </summary>
        [PropertyDescription(valueOffset: 0x1c, valueSize: 0x02 * 4)]
        public IValueTypeArray<ushort> e_res { get; private set; }

        /// <summary>
        ///     OEM identifier.
        /// </summary>
        [PropertyDescription(valueOffset: 0x24, valueSize: 0x02)]
        public IValueType<ushort> e_oemid { get; private set; }

        /// <summary>
        ///     OEM information.
        /// </summary>
        [PropertyDescription(0x26, valueSize: 0x02)]
        public IValueType<ushort> e_oeminfo { get; private set; }

        /// <summary>
        ///     Reserved. Consists of 10 * UInt16.
        /// </summary>
        [PropertyDescription(valueOffset: 0x28, valueSize: 0x02 * 10)]
        public IValueTypeArray<ushort> e_res2 { get; private set; }

        /// <summary>
        ///     Raw address of the NT header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x3c, valueSize: 0x04)]
        public IValueType<uint> e_lfanew { get; private set; }
    }
}
