using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageDosHeader : PEStructure, IImageDosHeader
    {
        public IProperty<ushort> e_magic => new PropertyUShort(0x00, 0x1100);
        public IProperty<ushort> e_cblp => new PropertyUShort(0x02, 0x3322);
        public IProperty<ushort> e_cp => new PropertyUShort(0x04, 0x5544);
        public IProperty<ushort> e_crlc => new PropertyUShort(0x06, 0x7766);
        public IProperty<ushort> e_cparhdr => new PropertyUShort(0x08, 0x9988);
        public IProperty<ushort> e_minalloc => new PropertyUShort(0x0a, 0xbbaa);
        public IProperty<ushort> e_maxalloc => new PropertyUShort(0x0c, 0xddcc);
        public IProperty<ushort> e_ss => new PropertyUShort(0x0e, 0x00ff);
        public IProperty<ushort> e_sp => new PropertyUShort(0x10, 0x2211);
        public IProperty<ushort> e_csum => new PropertyUShort(0x12, 0x4433);
        public IProperty<ushort> e_ip => new PropertyUShort(0x14, 0x6655);
        public IProperty<ushort> e_cs => new PropertyUShort(0x16, 0x8877);
        public IProperty<ushort> e_lfarlc => new PropertyUShort(0x18, 0xaa99);
        public IProperty<ushort> e_ovno => new PropertyUShort(0x1a, 0xccbb);
        public IProperty<ushort[]> e_res => new PropertyUShortArray(0x1c, 2 * 4, new ushort[]
        {
            0xeedd,
            0x00ff,
            0x2211,
            0x4433
        });
        public IProperty<ushort> e_oemid => new PropertyUShort(0x24, 0x6655);
        public IProperty<ushort> e_oeminfo => new PropertyUShort(0x26, 0x8877);
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
        public IProperty<uint> e_lfanew => new PropertyUInt(0x3c, 0x11ffeedd);
    }
}
