using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSALab1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = "F://WSALab1//WSALab1//File.txt";
            string lab1a=RemoveSGML.Remove(path);

            String delimiters = "!@#$%^&*()-=_+{}|\\][:\"';?><,./ ";
            string[] lab1b = Tools.Tokenize(lab1a, delimiters);
            


          

        }
    }
}
