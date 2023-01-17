using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dir = Path.GetFullPath(Directory.GetCurrentDirectory());
            List<string> files = Directory.GetFiles(dir, "*.*", SearchOption.AllDirectories)
              .Where(file => new string[] { ".jpg", ".gif", ".png", ".cs", ".exe", ".cache", ".*", ".config" }
              .Contains(Path.GetExtension(file)))
              .ToList();

            Console.WriteLine(dir);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }

            Console.ReadLine();
        }
    }
}
