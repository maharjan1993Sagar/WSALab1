using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NltkNet;

namespace WSALab1
{
    public static class Lab1Q2
    {
        //Nltk.Init(new List<string>
        //    {
        //        @"C:\IronPython27\Lib",
        //        @"C:\IronPython27\Lib\site-packages",
        //    });
        public static string[] stopWords ={"i", "me", "my", "myself", "we", "our", "ours", "ourselves", "you", "your", "yours", "yourself",
                                            "yourselves", "he", "him", "his", "himself", "she", "her", "hers", "herself", "it", "its", "itself",
                                            "they", "them", "their", "theirs", "themselves", "what", "which", "who", "whom", "this", "that", "these",
                                            "those", "am", "is", "are", "was", "were", "be", "been", "being", "have", "has", "had", "having", "do", "does",
                                            "did", "doing", "a", "an", "the", "and", "but", "if", "or", "because", "as", "until", "while", "of", "at", "by",
                                            "for", "with", "about", "against", "between", "into", "through", "during", "before", "after", "above", "below",
                                            "to", "from", "up", "down", "in", "out", "on", "off", "over", "under", "again", "further", "then", "once",
                                            "here", "there", "when", "where", "why", "how", "all", "any", "both", "each", "few", "more", "most", "other",
                                            "some", "such", "no", "nor", "not", "only", "own", "same", "so", "than", "too", "very", "s", "t", "can", "will",
                                            "just", "don", "should", "now" };

        public static int VocSize;
        public static List<WordCollection> WordsCollection { get; set; }


        public static List<WordCollection> FindCollection(string[] text)
        {
            // var uniqueTokens = text.GroupBy(z => z).Where(z => z.Count() == 1).OrderByDescending(z => z.Count()).Select(z=>z).ToList();
            WordsCollection = text.GroupBy(x => x).Select(y => new WordCollection { Key = y.Key, Count = y.Count() }).OrderByDescending(z => z.Count).ToList();
            VocSize = WordsCollection.Count();

            return WordsCollection;
        }

        public static int VocabularySize()
        {

            return VocSize;
        }

        public static List<WordCollection> TopWords()
        {
            return WordsCollection.OrderByDescending(z => z.Count).Take(10).ToList();
        }

        public static List<String> TopMeaningWord()
        {
            List<string> TopWords = Lab1Q2.TopWords().Select(m => m.Key).Except(stopWords).ToList();

            return TopWords;

        }

        public static int UniqueWords()
        {
            int i = 0;
            int count = 0;
            foreach (var item in TopWords())
            {
                count = count + item.Count;
                if (count < VocSize / 2)
                    i++;
                if (count > VocSize / 2)
                    break;
            }
            return i;
        }

    }
}
