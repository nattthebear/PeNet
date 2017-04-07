using PeNet.PropertyTypes;

namespace PeNet.Structures
{
    /// <summary>
    ///     The IMAGE_DOS_HEADER with which every PE file starts.
    /// </summary>
    public interface IImageDosHeader
    {
        /// <summary>
        ///     Magic "MZ" header.
        /// </summary>
        IProperty<ushort> e_magic { get; }

        /// <summary>
        ///     Bytes on the last page of the file.
        /// </summary>
        IProperty<ushort> e_cblp { get; }

        /// <summary>
        ///     Pages in the file.
        /// </summary>
        IProperty<ushort> e_cp { get; }

        /// <summary>
        ///     Relocations.
        /// </summary>
        IProperty<ushort> e_crlc { get; }

        /// <summary>
        ///     Size of the header in paragraphs.
        /// </summary>
        IProperty<ushort> e_cparhdr { get; }

        /// <summary>
        ///     Minimum extra paragraphs needed.
        /// </summary>
        IProperty<ushort> e_minalloc { get; }

        /// <summary>
        ///     Maximum extra paragraphs needed.
        /// </summary>
        IProperty<ushort> e_maxalloc { get; }

        /// <summary>
        ///     Initial (relative) SS value.
        /// </summary>
        IProperty<ushort> e_ss { get; }

        /// <summary>
        ///     Initial SP value.
        /// </summary>
        IProperty<ushort> e_sp { get; }

        /// <summary>
        ///     Checksum
        /// </summary>
        IProperty<ushort> e_csum { get; }

        /// <summary>
        ///     Initial IP value.
        /// </summary>
        IProperty<ushort> e_ip { get; }

        /// <summary>
        ///     Initial (relative) CS value.
        /// </summary>
        IProperty<ushort> e_cs { get; }

        /// <summary>
        ///     Raw address of the relocation table.
        /// </summary>
        IProperty<ushort> e_lfarlc { get; }

        /// <summary>
        ///     Overlay number.
        /// </summary>
        IProperty<ushort> e_ovno { get; }

        /// <summary>
        ///     Reserved. Consists of 4 * UInt16.
        /// </summary>
        IProperty<ushort[]> e_res { get; }

        /// <summary>
        ///     OEM identifier.
        /// </summary>
        IProperty<ushort> e_oemid { get; }

        /// <summary>
        ///     OEM information.
        /// </summary>
        IProperty<ushort> e_oeminfo { get; }

        /// <summary>
        ///     Reserved. Consits of 10 * UInt16.
        /// </summary>
        IProperty<ushort[]> e_res2 { get; }

        /// <summary>
        ///     Raw address of the NT header.
        /// </summary>
        IProperty<uint> e_lfanew { get; }

        /// <summary>
        ///     Creates a string representation of all properties.
        /// </summary>
        /// <returns>The header properties as a string.</returns>
        string ToString();
    }
}