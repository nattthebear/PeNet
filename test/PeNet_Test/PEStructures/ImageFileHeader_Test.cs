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

            Assert.True(testFh == ifh);
        }
    }
}