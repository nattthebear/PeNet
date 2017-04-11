using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PeNet.PropertyTypes;
using System.Reflection;

namespace PeNet.Structures
{
    /// <summary>
    ///     The IMAGE_DOS_HEADER with which every PE file starts.
    /// </summary>
    public class ImageDosHeader : IImageDosHeader
    {
        private uint _structOffset { get; set; }
        private byte[] _buffer { get; set; }

        /// <summary>
        ///     Create a new IMAGE_DOS_HEADER object.
        /// </summary>
        /// <param name="buff">Byte buffer containing a PE file.</param>
        /// <param name="offset">Offset in the buffer to the DOS header.</param>
        public ImageDosHeader(byte[] buff, uint offset)
        {
            _buffer = buff;
            _structOffset = offset;
            ParseProperties();
        }


        private void ParseProperties()
        {
            var properties = GetType().GetProperties().Where(p => typeof(IProperty).IsAssignableFrom(p.PropertyType)).ToList();
            var propertyTuples = new List<Tuple<PropertyDescription, PropertyInfo>>();

            foreach (var p in properties)
            {
                var description = p.GetCustomAttribute(typeof(PropertyDescription)) as PropertyDescription;
                propertyTuples.Add(new Tuple<PropertyDescription, PropertyInfo>(description, p));
            }

            // Order by the offset to have the correct order of properties in
            // the PE structure.
            propertyTuples = propertyTuples.OrderBy(t => t.Item1.ValueOffset).ToList();

            foreach (var pt in propertyTuples)
            {
                pt.Item2.SetValue(this, CreateProperty(pt.Item1, pt.Item2));
            }
        }

        private IProperty CreateProperty(PropertyDescription description, PropertyInfo info)
        {
            var propertyType = GetPropertyType(info.PropertyType.GetGenericArguments()[0]);

            if(propertyType == null)
                throw new Exception($"No compatible property type of type {info.PropertyType.Name} found.");

            return (IProperty) Activator.CreateInstance(propertyType, _buffer, _structOffset,  description.ValueOffset, description.ValueSize);
        }

        private Type GetPropertyType(Type innerType)
        {
            var peNet = typeof(IProperty).GetTypeInfo().Assembly;
            var propertyTypes = peNet.GetTypes()
                .Where(t => t.GetTypeInfo().GetCustomAttribute(typeof(PropertyType)) != null);

            return propertyTypes.FirstOrDefault(
                p => (p.GetTypeInfo().GetCustomAttribute(typeof(PropertyType)) as PropertyType)?.Type == innerType);
        }

        /// <summary>
        ///     Magic "MZ" header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x00, valueSize: 0x02)]
        public IProperty<ushort> e_magic { get; private set; }

        /// <summary>
        ///     Bytes on the last page of the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x02, valueSize: 0x02)]
        public IProperty<ushort> e_cblp { get; private set; }

        /// <summary>
        ///     Pages in the file.
        /// </summary>
        [PropertyDescription(valueOffset: 0x04, valueSize: 0x02)]
        public IProperty<ushort> e_cp { get; private set; }

        /// <summary>
        ///     Relocations.
        /// </summary>
        [PropertyDescription(valueOffset: 0x06, valueSize: 0x02)]
        public IProperty<ushort> e_crlc { get; private set; }

        /// <summary>
        ///     Size of the header in paragraphs.
        /// </summary>
        [PropertyDescription(valueOffset: 0x08, valueSize: 0x02)]
        public IProperty<ushort> e_cparhdr { get; private set; }


        /// <summary>
        ///     Minimum extra paragraphs needed.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0a, valueSize: 0x02)]
        public IProperty<ushort> e_minalloc { get; private set; }

        /// <summary>
        ///     Maximum extra paragraphs needed.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0c, valueSize: 0x02)]
        public IProperty<ushort> e_maxalloc { get; private set; }


        /// <summary>
        ///     Initial (relative) SS value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x0e, valueSize: 0x02)]
        public IProperty<ushort> e_ss { get; private set; }


        /// <summary>
        ///     Initial SP value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x10, valueSize: 0x02)]
        public IProperty<ushort> e_sp { get; private set; }

        /// <summary>
        ///     Checksum
        /// </summary>
        [PropertyDescription(valueOffset: 0x12, valueSize: 0x02)]
        public IProperty<ushort> e_csum { get; private set; }

        /// <summary>
        ///     Initial IP value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x14, valueSize: 0x02)]
        public IProperty<ushort> e_ip { get; private set; }

        /// <summary>
        ///     Initial (relative) CS value.
        /// </summary>
        [PropertyDescription(valueOffset: 0x16, valueSize: 0x02)]
        public IProperty<ushort> e_cs { get; private set; }

        /// <summary>
        ///     Raw address of the relocation table.
        /// </summary>
        [PropertyDescription(valueOffset: 0x18, valueSize: 0x02)]
        public IProperty<ushort> e_lfarlc { get; private set; }

        /// <summary>
        ///     Overlay number.
        /// </summary>
        [PropertyDescription(valueOffset: 0x1a, valueSize: 0x02)]
        public IProperty<ushort> e_ovno { get; private set; }

        /// <summary>
        ///     Reserved. Consists of 4 * UInt16.
        /// </summary>
        [PropertyDescription(valueOffset: 0x1c, valueSize: 0x02 * 4)]
        public IProperty<ushort[]> e_res { get; private set; }

        /// <summary>
        ///     OEM identifier.
        /// </summary>
        [PropertyDescription(valueOffset: 0x24, valueSize: 0x02)]
        public IProperty<ushort> e_oemid { get; private set; }

        /// <summary>
        ///     OEM information.
        /// </summary>
        [PropertyDescription(0x26, valueSize: 0x02)]
        public IProperty<ushort> e_oeminfo { get; private set; }

        /// <summary>
        ///     Reserved. Consists of 10 * UInt16.
        /// </summary>
        [PropertyDescription(valueOffset: 0x28, valueSize: 0x02 * 10)]
        public IProperty<ushort[]> e_res2 { get; private set; }

        /// <summary>
        ///     Raw address of the NT header.
        /// </summary>
        [PropertyDescription(valueOffset: 0x3c, valueSize: 0x04)]
        public IProperty<uint> e_lfanew { get; private set; }

        /// <summary>
        ///     Creates a string representation of all properties.
        /// </summary>
        /// <returns>The header properties as a string.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder("IMAGE_DOS_HEADER\n");
            return sb.ToString();
        }
    }
}
