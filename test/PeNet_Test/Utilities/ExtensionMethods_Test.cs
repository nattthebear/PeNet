using System.Collections.Generic;
using PeNet.Utilities;
using Xunit;

namespace PeNet_Test.Utilities
{
    public class ExtensionMethods_Test
    {
        [Fact]
        public void BytesToUInt16_BufferAndOffset_CorrectUShort()
        {
            var buff = new byte[] {0x11, 0x22, 0x33, 0x44};
            var offset = 1u;

            var actual = buff.BytesToUInt16(offset);

            Assert.Equal(0x3322, actual);
        }

        [Fact]
        public void BytesToUInt32_BufferAndOffset_CorrectUInt()
        {
            var buff = new byte[] {0x11, 0x22, 0x33, 0x44, 0x55, 0x66, 0x77};
            var offset = 1u;

            var actual = buff.BytesToUInt32(offset);

            Assert.Equal(0x55443322u, actual);
        }

        [Fact]
        public void ToBytes_UShortArray_CorrectByteArray()
        {
            var inputArray = new ushort[] {0x0011, 0x2233, 0x4455};

            var actual = inputArray.ToBytes();

            var expected = new byte[] {0x11, 0x00, 0x33, 0x22, 0x55, 0x44};
            Assert.True(expected.ListCompare(actual));
        }

        [Fact]
        public void ToBytes_UShort_CorrectByteArray()
        {
            ushort input = 0x1122;

            var actual = input.ToBytes();

            var expected = new byte[] { 0x22, 0x11 };
            Assert.True(expected.ListCompare(actual));
        }

        [Fact]
        public void ToBytes_UInt_CorrectByteArray()
        {
            var input = 0x11223344u;

            var actual = input.ToBytes();

            var expected = new byte[] { 0x44, 0x33, 0x22, 0x11 };
            Assert.True(expected.ListCompare(actual));
        }

        [Fact]
        public void ListCompare_TwoEqualList_True()
        {
            var l1 = new List<int> { 1, 2, 3, 4 };
            var l2 = new List<int> { 1, 2, 3, 4 };

            Assert.True(l1.ListCompare(l2));
        }


        [Fact]
        public void ListCompare_TwoUnEqualList_False()
        {
            var l1 = new List<int> { 1, 2, 5, 4 };
            var l2 = new List<int> { 1, 2, 3, 4 };

            Assert.False(l1.ListCompare(l2));
        }

        [Fact]
        public void ListCompare_ListOfDiffSize_False()
        {
            var l1 = new List<int> { 1, 2, 3, 4, 6 };
            var l2 = new List<int> { 1, 2, 3, 4 };

            Assert.False(l1.ListCompare(l2));
        }
    }
}