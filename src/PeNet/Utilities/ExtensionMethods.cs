using System;
using System.Collections.Generic;
using System.Linq;
using PeNet.PropertyTypes;
using System.Reflection;

namespace PeNet.Utilities
{
    /// <summary>
    /// Useful extension method to work with
    /// primitive data types, arrays etc.
    /// </summary>
    public static class ExtensionMethods
    {
        /// <summary>
        ///     Convert a two bytes in a byte array to an 16 bit unsigned integer.
        /// </summary>
        /// <param name="buff">Byte buffer.</param>
        /// <param name="offset">Position of the high byte. Low byte is i+1.</param>
        /// <returns>UInt16 of the bytes in the buffer at position i and i+1.</returns>
        public static ushort BytesToUInt16(this byte[] buff, ulong offset)
        {
            return BytesToUInt16(buff[offset], buff[offset + 1]);
        }
        

        /// <summary>
        ///     Convert 4 consecutive bytes out of a buffer to an 32 bit unsigned integer.
        /// </summary>
        /// <param name="buff">Byte buffer.</param>
        /// <param name="offset">Offset of the highest byte.</param>
        /// <returns>UInt32 of 4 bytes.</returns>
        public static uint BytesToUInt32(this byte[] buff, ulong offset)
        {
            return BytesToUInt32(buff[offset], buff[offset + 1], buff[offset + 2], buff[offset + 3]);
        }

        /// <summary>
        ///  Convert an ushort array to 
        ///  an byte array.
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Byte array.</returns>
        public static byte[] ToBytes(this ushort[] value)
        {
            var bytes = new byte[value.Length * 2];
            for (var i = 0; i < value.Length; i++)
            {
                var b1 = value[i].ToBytes()[0];
                var b2 = value[i].ToBytes()[1];

                bytes[i * 2] = b1;
                bytes[i * 2 + 1] = b2;
            }

            return bytes;
        }

        /// <summary>
        ///     Convert an UIn16 to an byte array.
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>Two byte array of the input value.</returns>
        public static byte[] ToBytes(this ushort value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        ///     Convert an UInt32 value into an byte array.
        /// </summary>
        /// <param name="value">Value</param>
        /// <returns>4 byte array of the value.</returns>
        public static byte[] ToBytes(this uint value)
        {
            return BitConverter.GetBytes(value);
        }

        /// <summary>
        /// Compares the quality of the elements of two lists.
        /// </summary>
        /// <param name="first">First list.</param>
        /// <param name="second">Second list.</param>
        /// <returns>True if all elements are equal, else false.</returns>
        public static bool ListCompare<lType>(this IList<lType> first, IList<lType> second)
        {
            if (first.Count != second.Count)
                return false;

            return !first.Where((t, i) => !t.Equals(second[i])).Any();
        }

        /// <summary>
        ///     Convert to bytes to an 16 bit unsigned integer.
        /// </summary>
        /// <param name="b1">High byte.</param>
        /// <param name="b2">Low byte.</param>
        /// <returns>UInt16 of the input bytes.</returns>
        private static ushort BytesToUInt16(byte b1, byte b2)
        {
            return BitConverter.ToUInt16(new[] { b1, b2 }, 0);
        }

        /// <summary>
        ///     Convert 4 bytes to an 32 bit unsigned integer.
        /// </summary>
        /// <param name="b1">Highest byte.</param>
        /// <param name="b2">Second highest byte.</param>
        /// <param name="b3">Second lowest byte.</param>
        /// <param name="b4">Lowest byte.</param>
        /// <returns>UInt32 representation of the input bytes.</returns>
        private static uint BytesToUInt32(byte b1, byte b2, byte b3, byte b4)
        {
            return BitConverter.ToUInt32(new[] { b1, b2, b3, b4 }, 0);
        }
    }
}