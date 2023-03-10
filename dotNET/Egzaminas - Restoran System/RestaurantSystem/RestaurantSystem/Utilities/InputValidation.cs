using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantSystem.Utilities
{
    public static class InputValidation
    {
        public static int ValidateInput()
        {
            int Number = -1;
            bool isImputValid = false;
            while (!isImputValid)
            {
                Exception? err = null;
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Number = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                finally
                {
                    if (err == null && Number >= 0)
                    {
                        isImputValid = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Įvesta netinkama reikšmė. Bandykite dar kartą.");
                    }
                }
            }
            return Number;
        }

        public static int ValidateInput(int maxValue)
        {
            int Number = -1;
            bool isImputValid = false;
            while (!isImputValid)
            {
                Exception? err = null;
                try
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Number = int.Parse(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                catch (NullReferenceException ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    err = ex;
                }
                finally
                {
                    if (err == null && Number >= 0 && Number <= maxValue)
                    {
                        isImputValid = true;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Blogai įvestas pasirinkimas. Bandykite dar kartą.");
                    }
                }
            }
            return Number;
        }
    }
}
