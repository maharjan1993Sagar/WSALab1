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
            string lab1a=RemoveSGML.Remove(path).Replace(System.Environment.NewLine, " ");
            Console.WriteLine("\n-----------------------lab1(a)------------------------\n");
            Console.WriteLine(lab1a);
            Console.WriteLine("\n\n");

            String delimiters = "!@#$%^&*()-=_+{}|\\][:\"';?><,./ ";
            string[] lab1b = Tools.Tokenize(lab1a, delimiters);
            Console.WriteLine("\n-----------------------lab1(b)------------------------\n");
            Console.WriteLine(string.Join(" ",lab1b));
            Console.WriteLine("\n\n");

            Lab1Q2.FindCollection(lab1b);
            int vocabularySize = Lab1Q2.VocSize;
            Console.WriteLine("\n-----------------------lab2(a)------------------------\n");
            Console.WriteLine(vocabularySize);
            Console.WriteLine("\n\n");

            List<WordCollection> Top10Words = Lab1Q2.TopWords();
            Console.WriteLine("\n-----------------------lab2(b)------------------------\n");
            Console.WriteLine(string.Join(" ", Top10Words.Select(u=>u.Key).ToArray()));
            Console.WriteLine("\n\n");

            List<string> MeaningfulWord = Lab1Q2.TopMeaningWord();
            Console.WriteLine("\n-----------------------lab2(c)------------------------\n");
            Console.WriteLine(string.Join(" ",MeaningfulWord));
            Console.WriteLine("\n\n");

            int uniqueWordCount = Lab1Q2.UniqueWords();
            Console.WriteLine("\n-----------------------lab2(d)------------------------\n");
            Console.WriteLine(uniqueWordCount);
            Console.WriteLine("\n\n");

            Console.ReadKey();




        }
    }
}
