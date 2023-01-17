using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ReadFile
    {
        public ReadFile()
        {
            string filePath = @"H:\Shared drives\MG donisdonatas@gmail.com\Code Academy\Paskaitos\dotNET\Lesson 056 - Error Handling\ConsoleApp1\ConsoleApp1\CompanysList.txt";
            // Open the stream and read it.
            using (FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] b = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);


                try
                {
                    while (fs.Read(b, 0, b.Length) > 0)
                    {
                        Console.WriteLine(temp.GetString(b));
                    }
                }
                catch(FileNotFoundException)
                {
                    Console.WriteLine("Error: file not found");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Writing was disallowed, as expected: {0}", e.ToString());
                }
            }

            //System.IO.StreamReader sr = null;
            //try
            //{
            //    string file = @"H:\Shared drives\MG donisdonatas@gmail.com\Code Academy\Paskaitos\dotNET\Lesson 056 - Error Handling\ConsoleApp1\ConsoleApp1\CompanysList.txt";
            //    sr = new System.IO.StreamReader(file);
            //    Console.WriteLine(sr.ReadToEnd());
            //    //sr.Close();
            //}
            //catch(FileNotFoundException)
            //{
            //    Console.WriteLine("Error: file not found");
            //}
            //catch(OutOfMemoryException)
            //{
            //    Console.WriteLine("Error: memory exceeded the limit");
            //}
            //catch(AccessViolationException)
            //{
            //    Console.WriteLine("Error: you are trying to read from protected memory");
            //}
            //catch(DirectoryNotFoundException)
            //{
            //    Console.WriteLine("Error: Dirrectory not found");
            //}
            //finally
            //{
            //    sr.Close();
            //    Console.WriteLine("Don't forget to close file");
            //}
        }
    }
}
