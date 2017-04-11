using PeNet.PropertyTypes;
using PeNet.Structures;

namespace PeNet_Test.TestStructures
{
    public class ImageDosHeader : PEStructure, IImageDosHeader
    {
        public IProperty<ushort> e_magic => new PropertyUShort(0x00, 2, 0x1100);
        public IProperty<ushort> e_cblp => new PropertyUShort(0x02, 2, 0x3322);
        public IProperty<ushort> e_cp => new PropertyUShort(0x04, 2, 0x5544);
        public IProperty<ushort> e_crlc => new PropertyUShort(0x06, 2, 0x7766);
        public IProperty<ushort> e_cparhdr => new PropertyUShort(0x08, 2, 0x9988);
        public IProperty<ushort> e_minalloc => new PropertyUShort(0x0a, 2, 0xbbaa);
        public IProperty<ushort> e_maxalloc => new PropertyUShort(0x0c, 2, 0xddcc);
        public IProperty<ushort> e_ss => new PropertyUShort(0x0e, 2, 0x00ff);
        public IProperty<ushort> e_sp => new PropertyUShort(0x10, 2, 0x2211);
        public IProperty<ushort> e_csum => new PropertyUShort(0x12, 2, 0x4433);
        public IProperty<ushort> e_ip => new PropertyUShort(0x14, 2, 0x6655);
        public IProperty<ushort> e_cs => new PropertyUShort(0x16, 2, 0x8877);
        public IProperty<ushort> e_lfarlc => new PropertyUShort(0x18, 2, 0xaa99);
        public IProperty<ushort> e_ovno => new PropertyUShort(0x1a, 2, 0xccbb);
        public IProperty<ushort[]> e_res => new PropertyUShortArray(0x1c, 2 * 4, new ushort[]
        {
            0xeedd,
            0x00ff,
            0x2211,
            0x4433
        });
        public IProperty<ushort> e_oemid => new PropertyUShort(0x24, 2, 0x6655);
        public IProperty<ushort> e_oeminfo => new PropertyUShort(0x26, 2, 0x8877);
        public IProperty<ushort[]> e_res2 => new PropertyUShortArray(0x28, 2*10, new ushort[]
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
        public IProperty<uint> e_lfanew => new PropertyUInt(0x3c, 4, 0x11ffeedd);
    }
}
