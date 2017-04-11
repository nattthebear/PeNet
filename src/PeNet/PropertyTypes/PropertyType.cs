using System;

namespace PeNet.PropertyTypes
{
    /// <summary>
    /// Describes the type of a 
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class PropertyType : Attribute
    {
        /// <summary>
        /// The type of the property value.
        /// </summary>
        public Type Type { get; }

        /// <summary>
        /// Create a new PropertyType attribute object.
        /// </summary>
        /// <param name="type">Type of the property value.</param>
        public PropertyType(Type type)
        {
            Type = type;
        }
    }
}