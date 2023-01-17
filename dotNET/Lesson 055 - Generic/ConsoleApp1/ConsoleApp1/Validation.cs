using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Validation<T>
    {
        public void Validate(T input)
        {
            if (input == null) throw new ArgumentNullException(nameof(input));
        }

        public void showError()
        {
            Console.WriteLine("You get error");
        }
    }
}
