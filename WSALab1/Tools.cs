using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WSALab1
{
    public static class Tools
    {

        public static String[] Tokenize(string line, string delims)
        {
            Char[] delimiters = delims.ToCharArray();
            String trimmedLine = line.Trim();
            int stringLength = trimmedLine.Length;
            List<String> tokenizedList = new List<string>();

            String subString;
            int startPos = 0;
            int endPos = 0;
            string[] tokens;

            while (startPos < stringLength)
            {
                endPos = trimmedLine.IndexOfAny(delimiters, startPos);
                if (endPos - startPos > 0)
                {
                    subString = trimmedLine.Substring(startPos, endPos - startPos).Trim();
                    tokenizedList.Add(subString);
                }
                else if (endPos - startPos == 0)
                {
                    subString = trimmedLine.Substring(startPos, 1).Trim();
                    tokenizedList.Add(subString);
                }
                startPos = endPos + 1;
            }
            for (int i = 0; i < tokenizedList.Count; i++)
            {
                if (Regex.IsMatch(tokenizedList[i], @"^[a-zA-Z0-9_]+$"))
                {
                   if (tokenizedList[i].Contains('.'))
                        tokenizedList[i].Replace(".", string.Empty);
                }
                else 
                    tokenizedList.Remove(tokenizedList[i]);

                
            }
            

            tokens = tokenizedList.ToArray().Where(x => !string.IsNullOrEmpty(x)).ToArray(); ;

            return tokens;

        }


    }
}
