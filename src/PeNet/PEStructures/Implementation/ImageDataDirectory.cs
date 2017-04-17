using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     The IMAGE_DATA_DIRECTORY struct represents an
    ///     entry in the data directory array.
    /// </summary>
    public class ImageDataDirectory : PEStructure, IImageDataDirectory
    {
        /// <summary>
        /// Create a new IMAGE_DATA_DIRECTORY object.
        /// </summary>
        /// <param name="buff">Buffer containing the struct.</param>
        /// <param name="offset">Offset of the struct in the buffer.</param>
        public ImageDataDirectory(byte[] buff, uint offset)
            : base(buff, offset) { }

        /// <summary>
        ///     RVA of the table.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x04)]
        public IProperty<uint> VirtualAddress { get; private set; }

        /// <summary>
        ///     Table size in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x04)]
        public IProperty<uint> Size { get; private set; }
    }
}