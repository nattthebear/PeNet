using PeNet.PEStructures.Implementation;
using Xunit;

namespace PeNet_Test.PEStructures
{
    public class ImageDataDirectory_Test
    {
        [Fact]
        public void ImageDataDirectory_RawDataDir_SetsAllProperties()
        {
            var testDd = new TestStructures.ImageDataDirectory();

            var idd = new ImageDataDirectory(testDd.SerializeToBytes(), 0);

            Assert.True(testDd == idd);
        }
    }
}