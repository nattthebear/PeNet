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
        IValueType<uint> VirtualAddress { get; }

        /// <summary>
        ///     Table size in bytes.
        /// </summary>
        IValueType<uint> Size { get; }
    }
}