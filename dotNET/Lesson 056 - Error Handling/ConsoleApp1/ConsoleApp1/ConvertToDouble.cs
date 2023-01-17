using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ConvertToDouble
    {
        public ConvertToDouble()
        {
            try
            {
                double doubleNumber = System.Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("String converted to double is: " + doubleNumber);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: this string can't be converted to Double. " + e.ToString());
            }
            catch (OverflowException e)
            {
                Console.WriteLine("Error: value represents a number that is less than System.Double.MinValue or greater than System.Double.MaxValue.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.ToString());
            }
            finally
            {
                Console.WriteLine("End of program 1.");
            }
        }
    }
}
