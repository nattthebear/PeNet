// <copyright file="ImageExportDirectoriesParserTest.cs">Copyright ©  2016</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PeNet.Parser.Tests
{
    [TestClass]
    [PexClass(typeof(ImageExportDirectoriesParser))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class ImageExportDirectoriesParserTest
    {
        [PexMethod]
        internal ImageExportDirectoriesParser Constructor(byte[] buff, uint offset)
        {
            var target = new ImageExportDirectoriesParser(buff, offset);
            return target;
            // TODO: add assertions to method ImageExportDirectoriesParserTest.Constructor(Byte[], UInt32)
        }
    }
}