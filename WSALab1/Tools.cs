using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    subString = trimmedLine.Substring(startPos, endPos - startPos);
                    tokenizedList.Add(subString);
                }
                else if (endPos - startPos == 0)
                {
                    subString = trimmedLine.Substring(startPos, 1);
                    tokenizedList.Add(subString);
                }
                startPos = endPos + 1;
            }

            tokens = tokenizedList.ToArray();

            return tokens;

        }


    }
}
