using PeNet.PEStructures.Implementation;
using Xunit;

namespace PeNet_Test.PEStructures
{
    public class ImageOptionalHeader32_Test
    {
        [Fact]
        public void ImageOptionalHeader32_RawOptionalHeader_SetsAllProperties()
        {
            var testOh = new TestStructures.ImageOptionalHeader32();

            var ioh = new ImageOptionalHeader32(testOh.SerializeToBytes(), 0);

            Assert.True(testOh == ioh);
        }
    }
}