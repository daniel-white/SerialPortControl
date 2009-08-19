using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Xml.Linq;

namespace SerialPortControl
{
    public static class ExtensionMethods
    {
        public static T ToEnumValue<T>(this string str)
        {
            return (T)Enum.Parse(typeof(T), str, true);
        }

        public static T ToEnumValue<T>(this XAttribute obj)
        {
            return ToEnumValue<T>(obj.Value);
        }

        public static T ToEnumValue<T>(this XElement obj)
        {
            return ToEnumValue<T>(obj.Value);
        }



    }
}
