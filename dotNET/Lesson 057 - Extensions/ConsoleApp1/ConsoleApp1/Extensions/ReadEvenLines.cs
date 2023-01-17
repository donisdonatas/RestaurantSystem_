using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1.Extensions
{
    public static class ReadEvenLines
    {
        public static List<string> readEveryOtherLine(this FileInfo listFromFile, bool isEven)
        {
            List<string> everyOtherLine = new List<string>();
            using (StreamReader sr = listFromFile.OpenText())
            {
                int lineNumber = 0;
                while (sr.Peek() >= 0)
                {
                    lineNumber++;
                    string line = sr.ReadLine();
                    if((isEven && lineNumber % 2 == 0) || (!isEven && lineNumber % 2 != 0))
                    {
                        everyOtherLine.Add(line);
                    }
                }
            }
            return everyOtherLine;
        }
    }
}
