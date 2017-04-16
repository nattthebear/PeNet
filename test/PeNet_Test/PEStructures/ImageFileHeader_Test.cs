using PeNet.PEStructures.Implementation;
using Xunit;

namespace PeNet_Test.PEStructures
{
    public class ImageFileHeader_Test
    {
        [Fact]
        public void ImageFileHeader_RawFileHeader_SetsAllProperties()
        {
            var testFh = new TestStructures.ImageFileHeader();

            var ifh = new ImageFileHeader(testFh.SerializeToBytes(), 0);

            Assert.Equal(0x0011, ifh.Machine.Value);
            Assert.Equal(0x2233, ifh.NumberOfSections.Value);
            Assert.Equal(0x44556677u, ifh.TimeDateStamp.Value);
            Assert.Equal(0x8899aabbu, ifh.PointerToSymbolTable.Value);
            Assert.Equal(0xccddeeffu, ifh.NumberOfSymbols.Value);
            Assert.Equal(0x1122, ifh.SizeOfOptionalHeader.Value);
            Assert.Equal(0x3344, ifh.Characteristics.Value);
        }
    }
}