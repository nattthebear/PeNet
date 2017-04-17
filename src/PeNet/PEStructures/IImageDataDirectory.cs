using PeNet.PropertyTypes;

namespace PeNet.PEStructures
{
    /// <summary>
    ///     The IMAGE_DATA_DIRECTORY struct represents an
    ///     entry in the data directory array.
    /// </summary>
    public interface IImageDataDirectory
    {
        /// <summary>
        ///     RVA of the table.
        /// </summary>
        IProperty<uint> VirtualAddress { get; }

        /// <summary>
        ///     Table size in bytes.
        /// </summary>
        IProperty<uint> Size { get; }
    }
}