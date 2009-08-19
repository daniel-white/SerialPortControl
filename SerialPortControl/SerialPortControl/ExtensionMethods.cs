﻿using System;
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


        public static IEnumerable<T> GetEnumValues<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>();
        }


        public static IDictionary<string, int> GetEnumAsDictionary<T>()
        {
            Dictionary<string, int> output = new Dictionary<string,int>();

            foreach (T t in GetEnumValues<T>())
            {
                output.Add(t.ToString, (int)t);
            }

            return output;
        }

        public static 



    }
}
