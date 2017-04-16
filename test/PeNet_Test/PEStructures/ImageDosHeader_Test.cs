using PeNet.PEStructures;
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

            Assert.Equal(testIdh.e_magic, idh.e_magic);
            Assert.Equal(testIdh.e_cblp, idh.e_cblp);
            Assert.Equal(testIdh.e_cp, idh.e_cp);
            Assert.Equal(testIdh.e_crlc, idh.e_crlc);
            Assert.Equal(testIdh.e_cparhdr, idh.e_cparhdr);
            Assert.Equal(testIdh.e_minalloc, idh.e_minalloc);
            Assert.Equal(testIdh.e_maxalloc, idh.e_maxalloc);
            Assert.Equal(testIdh.e_ss, idh.e_ss);
            Assert.Equal(testIdh.e_sp, idh.e_sp);
            Assert.Equal(testIdh.e_csum, idh.e_csum);
            Assert.Equal(testIdh.e_ip, idh.e_ip);
            Assert.Equal(testIdh.e_cs, idh.e_cs);
            Assert.Equal(testIdh.e_lfarlc, idh.e_lfarlc);
            Assert.Equal(testIdh.e_ovno, idh.e_ovno);
            Assert.Equal(testIdh.e_res, idh.e_res);
            Assert.Equal(testIdh.e_oemid, idh.e_oemid);
            Assert.Equal(testIdh.e_oeminfo, idh.e_oeminfo);
            Assert.Equal(testIdh.e_res2, idh.e_res2);
            Assert.Equal(testIdh.e_lfanew, idh.e_lfanew);
        }
    }
}