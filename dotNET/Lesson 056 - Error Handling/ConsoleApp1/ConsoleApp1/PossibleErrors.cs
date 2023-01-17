using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class PossibleErrors
    {
        public PossibleErrors()
        {
            int[] arr = { 19, 0, 75, 52 };

            try
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Error: You are trying to divide by 0");
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Error: you are trying to access Array element outside of range");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
