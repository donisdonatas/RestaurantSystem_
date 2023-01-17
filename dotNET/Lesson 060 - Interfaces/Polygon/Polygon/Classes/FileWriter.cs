using Polygon.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygon.Classes
{
    public class FileWriter : IWriteableToFile
    {
        string SolutionPath = Path.GetFullPath(Directory.GetCurrentDirectory());
        string FileLocation = @"..\..\..\";
        public override string ToString()
        {
            string ObjectInString = string.Empty;
            return ObjectInString;
        }

        public void WriteToFile(string fileName)
        {
            string FilePath = Path.Combine(SolutionPath, FileLocation, fileName);
            using (StreamWriter streamWriter = File.AppendText(FilePath))
            {
                streamWriter.WriteLine(this.ToString());
            };
        }
    }
}
