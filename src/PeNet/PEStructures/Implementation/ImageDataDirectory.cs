using PeNet.PropertyTypes;

namespace PeNet.PEStructures.Implementation
{
    /// <summary>
    ///     The IMAGE_DATA_DIRECTORY struct represents an
    ///     entry in the data directory array.
    /// </summary>
    public class ImageDataDirectory : IImageDataDirectory
    {
        /// <summary>
        /// Create a new IMAGE_DATA_DIRECTORY object.
        /// </summary>
        /// <param name="virtualAddress">Virtual address of the directory entry.</param>
        /// <param name="size">Size of the directory entry.</param>
        public ImageDataDirectory(IValueType<uint> virtualAddress, IValueType<uint> size)
        {
            VirtualAddress = virtualAddress;
            Size = size;
        }

        /// <summary>
        ///     RVA of the table.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x04)]
        public IValueType<uint> VirtualAddress { get; private set; }

        /// <summary>
        ///     Table size in bytes.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x04)]
        public IValueType<uint> Size { get; private set; }
    }
}