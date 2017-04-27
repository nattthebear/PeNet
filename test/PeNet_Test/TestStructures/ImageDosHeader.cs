using PeNet.PEStructures;
using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class ImageDosHeader : IImageDosHeader
    {
        public IValueType<ushort> e_magic => new ValueType<ushort>(0x00, sizeof(ushort), 0x1100);
        public IValueType<ushort> e_cblp => new ValueType<ushort>(0x02, sizeof(ushort), 0x3322);
        public IValueType<ushort> e_cp => new ValueType<ushort>(0x04, sizeof(ushort), 0x5544);
        public IValueType<ushort> e_crlc => new ValueType<ushort>(0x06, sizeof(ushort), 0x7766);
        public IValueType<ushort> e_cparhdr => new ValueType<ushort>(0x08, sizeof(ushort), 0x9988);
        public IValueType<ushort> e_minalloc => new ValueType<ushort>(0x0a, sizeof(ushort), 0xbbaa);
        public IValueType<ushort> e_maxalloc => new ValueType<ushort>(0x0c, sizeof(ushort), 0xddcc);
        public IValueType<ushort> e_ss => new ValueType<ushort>(0x0e, sizeof(ushort), 0x00ff);
        public IValueType<ushort> e_sp => new ValueType<ushort>(0x10, sizeof(ushort), 0x2211);
        public IValueType<ushort> e_csum => new ValueType<ushort>(0x12, sizeof(ushort), 0x4433);
        public IValueType<ushort> e_ip => new ValueType<ushort>(0x14, sizeof(ushort), 0x6655);
        public IValueType<ushort> e_cs => new ValueType<ushort>(0x16, sizeof(ushort), 0x8877);
        public IValueType<ushort> e_lfarlc => new ValueType<ushort>(0x18, sizeof(ushort), 0xaa99);
        public IValueType<ushort> e_ovno => new ValueType<ushort>(0x1a, sizeof(ushort), 0xccbb);
        public IValueTypeArray<ushort> e_res => new ValueTypeArray<ushort>(0x1c, 2 * 4, new ushort[]
        {
            0xeedd,
            0x00ff,
            0x2211,
            0x4433
        });
        public IValueType<ushort> e_oemid => new ValueType<ushort>(0x24, sizeof(ushort), 0x6655);
        public IValueType<ushort> e_oeminfo => new ValueType<ushort>(0x26, sizeof(ushort), 0x8877);
        public IValueType<ushort[]> e_res2 => new ValueType<ushort>Array(0x28, 2*10, new ushort[]
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
        public IValueType<uint> e_lfanew => new PropertyUInt(0x3c, 0x11ffeedd);
    }
}
