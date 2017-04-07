using System.Text;
using PeNet.PropertyTypes;

namespace PeNet.Structures
{
    /// <summary>
    ///     The IMAGE_DOS_HEADER with which every PE file starts.
    /// </summary>
    public class ImageDosHeader : IImageDosHeader
    {
        private readonly PropertyValueParser _propertyValueParser;

        /// <summary>
        ///     Create a new IMAGE_DOS_HEADER object.
        /// </summary>
        /// <param name="buff">Byte buffer containing a PE file.</param>
        /// <param name="offset">Offset in the buffer to the DOS header.</param>
        public ImageDosHeader(byte[] buff, uint offset)
        {
            _propertyValueParser = new PropertyValueParser(buff, offset);
            ParseProperties();
        }

        private void ParseProperties()
        {
            e_magic = new PropertyUShort(_propertyValueParser);
            e_cblp = new PropertyUShort(_propertyValueParser);
            e_cp = new PropertyUShort(_propertyValueParser);
            e_crlc = new PropertyUShort(_propertyValueParser);
            e_cparhdr = new PropertyUShort(_propertyValueParser);
            e_minalloc = new PropertyUShort(_propertyValueParser);
            e_maxalloc = new PropertyUShort(_propertyValueParser);
            e_ss = new PropertyUShort(_propertyValueParser);
            e_sp = new PropertyUShort(_propertyValueParser);
            e_csum = new PropertyUShort(_propertyValueParser);
            e_ip = new PropertyUShort(_propertyValueParser);
            e_cs = new PropertyUShort(_propertyValueParser);
            e_lfarlc = new PropertyUShort(_propertyValueParser);
            e_ovno = new PropertyUShort(_propertyValueParser);
            e_res = new PropertyUShortArray(_propertyValueParser, 4);
            e_oemid = new PropertyUShort(_propertyValueParser);
            e_oeminfo = new PropertyUShort(_propertyValueParser);
            e_res2 = new PropertyUShortArray(_propertyValueParser, 10);
            e_lfanew = new PropertyUInt(_propertyValueParser);
        }

        /// <summary>
        ///     Magic "MZ" header.
        /// </summary>
        public IProperty<ushort> e_magic { get; private set; }

        /// <summary>
        ///     Bytes on the last page of the file.
        /// </summary>
        public IProperty<ushort> e_cblp { get; private set; }

        /// <summary>
        ///     Pages in the file.
        /// </summary>
        public IProperty<ushort> e_cp { get; private set; }

        /// <summary>
        ///     Relocations.
        /// </summary>
        public IProperty<ushort> e_crlc { get; private set; }

        /// <summary>
        ///     Size of the header in paragraphs.
        /// </summary>
        public IProperty<ushort> e_cparhdr { get; private set; }


        /// <summary>
        ///     Minimum extra paragraphs needed.
        /// </summary>
        public IProperty<ushort> e_minalloc { get; private set; }

        /// <summary>
        ///     Maximum extra paragraphs needed.
        /// </summary>
        public IProperty<ushort> e_maxalloc { get; private set; }


        /// <summary>
        ///     Initial (relative) SS value.
        /// </summary>
        public IProperty<ushort> e_ss { get; private set; }


        /// <summary>
        ///     Initial SP value.
        /// </summary>
        public IProperty<ushort> e_sp { get; private set; }

        /// <summary>
        ///     Checksum
        /// </summary>
        public IProperty<ushort> e_csum { get; private set; }

        /// <summary>
        ///     Initial IP value.
        /// </summary>
        public IProperty<ushort> e_ip { get; private set; }

        /// <summary>
        ///     Initial (relative) CS value.
        /// </summary>
        public IProperty<ushort> e_cs { get; private set; }

        /// <summary>
        ///     Raw address of the relocation table.
        /// </summary>
        public IProperty<ushort> e_lfarlc { get; private set; }

        /// <summary>
        ///     Overlay number.
        /// </summary>
        public IProperty<ushort> e_ovno { get; private set; }

        /// <summary>
        ///     Reserved. Consists of 4 * UInt16.
        /// </summary>
        public IProperty<ushort[]> e_res { get; private set; }

        /// <summary>
        ///     OEM identifier.
        /// </summary>
        public IProperty<ushort> e_oemid { get; private set; }

        /// <summary>
        ///     OEM information.
        /// </summary>
        public IProperty<ushort> e_oeminfo { get; private set; }

        /// <summary>
        ///     Reserved. Consits of 10 * UInt16.
        /// </summary>
        public IProperty<ushort[]> e_res2 { get; private set; }

        /// <summary>
        ///     Raw address of the NT header.
        /// </summary>
        public IProperty<uint> e_lfanew { get; private set; }

        /// <summary>
        ///     Creates a string representation of all properties.
        /// </summary>
        /// <returns>The header properties as a string.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder("IMAGE_DOS_HEADER\n");
            return sb.ToString();
        }
    }
}
