using PeNet.Utilities;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Helper class for property parsing.
    /// </summary>
    public class PropertyValueParser
    {
        /// <summary>
        /// A byte buffer containing a PE structure.
        /// </summary>
        public readonly byte[] Buffer;

        /// <summary>
        /// The current offset of the parser.
        /// </summary>
        public uint CurrentOffset { get; internal set; }
       
        /// <summary>
        /// Create a new parser helper object.
        /// </summary>
        /// <param name="buffer">Buffer containing a PE structure.</param>
        /// <param name="startOffset">Start offset of the structure in the buffer.</param>
        public PropertyValueParser(byte[] buffer, uint startOffset)
        {
            Buffer = buffer;
            CurrentOffset = startOffset;
        }
    }
}