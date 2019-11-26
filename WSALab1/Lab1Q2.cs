using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSALab1
{
  public static class Lab1Q2
    {
        public static int VocSize;
        public static List<WordCollection> WordsCollection { get; set; }

        public static List<WordCollection> FindCollection(string[] text)
        {
            var uniqueTokens = text.GroupBy(z => z).Where(z => z.Count() == 1).OrderByDescending(z => z.Count()).Select(z=>z).ToList();
            WordsCollection = (from u in uniqueTokens
                                       select new WordCollection
                                       {
                                           Key = u.Key,
                                           Count = u.Count()
                                       }).ToList();
            VocSize = WordsCollection.Count();
           
            return WordsCollection;
        }

        public static int VocabularySize()
        {
            return VocSize;
        }

        public static List<WordCollection> TopWords()
        {
            return WordsCollection.Take(10).ToList();
        }

    }
}
