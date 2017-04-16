using PeNet.PEStructures.Implementation;
using Xunit;

namespace PeNet_Test.PEStructures
{
    public class ImageDosHeader_Test
    {
        [Fact]
        public void ImageDosHeader_RawDosHeader_SetsAllProperties()
        {
            var testIdh = new TestStructures.ImageDosHeader();

            var idh = new ImageDosHeader(testIdh.SerializeToBytes(), 0);

            Assert.True(testIdh == idh);
        }
    }
}