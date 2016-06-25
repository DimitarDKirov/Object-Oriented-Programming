using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    static class ExtensionMethods
    { 
        public static StringBuilder Substring(this StringBuilder builder, int index, int length)
        {
            string result = builder.ToString().Substring(index, length);
            return new StringBuilder(result);
        }
    }
}
