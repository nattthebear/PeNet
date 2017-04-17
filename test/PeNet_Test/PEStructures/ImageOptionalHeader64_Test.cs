using PeNet.PEStructures.Implementation;
using Xunit;

namespace PeNet_Test.PEStructures
{
    public class ImageOptionalHeader64_Test
    {
        [Fact]
        public void ImageOptionalHeader64_RawOptionalHeader_SetsAllProperties()
        {
            var testOh = new TestStructures.ImageOptionalHeader64();

            var ioh = new ImageOptionalHeader64(testOh.SerializeToBytes(), 0);

            Assert.True(testOh == ioh);
        }
    }
}