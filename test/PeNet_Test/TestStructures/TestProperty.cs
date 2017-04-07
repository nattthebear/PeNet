using PeNet.PropertyTypes;

namespace PeNet_Test.TestStructures
{
    public class TestProperty<TValue> : IProperty<TValue>
    {
        public TestProperty(ulong offset, uint size, TValue value)
        {
            RawOffset = offset;
            Size = size;
            Value = value;
        }

        public ulong RawOffset { get; }
        public uint Size { get; }
        public TValue Value { get; set; }

        public bool Equals(IProperty<TValue> other)
        {
            return other.Equals(this);
        }
    }
}