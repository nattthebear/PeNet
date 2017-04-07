using PeNet.PropertyTypes;
using PeNet.Structures;

namespace PeNet_Test.TestStructures
{
    public class ImageDosHeader : IImageDosHeader
    {
        public readonly byte[] RawBytes =
        {
            0x00, // e_magic
            0x11,
            0x22, // e_cblp
            0x33,
            0x44, // e_cp
            0x55,
            0x66, // e_crlc
            0x77,
            0x88, // e_cparhdr
            0x99,
            0xaa, // e_minalloc
            0xbb,
            0xcc, // e_maxalloc
            0xdd,
            0xff, // e_ss
            0x00,
            0x11, // e_sp
            0x22,
            0x33, // e_csum
            0x44,
            0x55, // e_ip
            0x66,
            0x77, // e_cs
            0x88,
            0x99, // e_lfalc
            0xaa,
            0xbb, // e_ovno
            0xcc,
            0xdd, // e_res
            0xee,
            0xff,
            0x00,
            0x11,
            0x22,
            0x33,
            0x44,
            0x55, // e_oemid
            0x66,
            0x77, // e_oeminfo
            0x88,
            0x99, // e_res2
            0xaa,
            0xbb,
            0xcc,
            0xdd,
            0xee,
            0xff,
            0x11,
            0x22,
            0x33,
            0x44,
            0x55,
            0x66,
            0x77,
            0x88,
            0x99,
            0xaa,
            0xbb,
            0xcc,
            0xbb,
            0xdd, // e_lfanew
            0xee,
            0xff,
            0x11
        };

        public IProperty<ushort> e_magic => new TestProperty<ushort>(0x00, 2, 0x1100);
        public IProperty<ushort> e_cblp => new TestProperty<ushort>(0x02, 2, 0x3322);
        public IProperty<ushort> e_cp => new TestProperty<ushort>(0x04, 2, 0x5544);
        public IProperty<ushort> e_crlc => new TestProperty<ushort>(0x06, 2, 0x7766);
        public IProperty<ushort> e_cparhdr => new TestProperty<ushort>(0x08, 2, 0x9988);
        public IProperty<ushort> e_minalloc => new TestProperty<ushort>(0x0a, 2, 0xbbaa);
        public IProperty<ushort> e_maxalloc => new TestProperty<ushort>(0x0c, 2, 0xddcc);
        public IProperty<ushort> e_ss => new TestProperty<ushort>(0x0e, 2, 0x00ff);
        public IProperty<ushort> e_sp => new TestProperty<ushort>(0x10, 2, 0x2211);
        public IProperty<ushort> e_csum => new TestProperty<ushort>(0x12, 2, 0x4433);
        public IProperty<ushort> e_ip => new TestProperty<ushort>(0x14, 2, 0x6655);
        public IProperty<ushort> e_cs => new TestProperty<ushort>(0x16, 2, 0x8877);
        public IProperty<ushort> e_lfarlc => new TestProperty<ushort>(0x18, 2, 0xaa99);
        public IProperty<ushort> e_ovno => new TestProperty<ushort>(0x1a, 2, 0xccbb);
        public IProperty<ushort[]> e_res => new TestProperty<ushort[]>(0x1c, 2 * 4, new ushort[]
        {
            0xeedd,
            0x00ff,
            0x2211,
            0x4433
        });
        public IProperty<ushort> e_oemid => new TestProperty<ushort>(0x24, 2, 0x6655);
        public IProperty<ushort> e_oeminfo => new TestProperty<ushort>(0x26, 2, 0x8877);
        public IProperty<ushort[]> e_res2 => new TestProperty<ushort[]>(0x28, 2*10, new ushort[]
        {
            0xaa99,
            0xccbb,
            0xeedd,
            0x11ff,
            0x3322,
            0x5544,
            0x7766,
            0x9988,
            0xbbaa,
            0xbbcc
        });
        public IProperty<uint> e_lfanew => new TestProperty<uint>(0x3c, 4, 0x11ffeedd);
    }
}
