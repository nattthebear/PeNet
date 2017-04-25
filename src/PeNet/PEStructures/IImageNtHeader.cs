using System;
using System.Collections.Generic;
using System.Text;
using PeNet.PropertyTypes;

namespace PeNet.PEStructures
{
    /// <summary>
    ///     The NT header is the main header for modern Windows applications.
    ///     It contains the file header and the optional header.
    /// </summary>
    interface IImageNtHeader
    {
        /// <summary>
        ///     Access to the File header.
        /// </summary>
        IProperty<IImageFileHeader> FileHeader { get; }

        /// <summary>
        ///     Access to the Optional header.
        /// </summary>
        IProgress<IImageOptionalHeader> OptionalHeader { get; }

        /// <summary>
        ///     NT header signature.
        /// </summary>
        IProperty<uint> Signature { get; }
    }
}
