using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSALab1
{
  public static  class RemoveSGML
    {
        public static string Remove(string filepath)
        {
            string Text = File.ReadAllText(filepath);
           return Regex.Replace(Text, "<.*?>", String.Empty);
           
        }
    }
}
