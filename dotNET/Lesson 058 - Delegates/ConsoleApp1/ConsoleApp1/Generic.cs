using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Generic<T>
    {
        //public T value;
        public string GetType(T value)
        {
            return typeof(T).ToString();
        }
    }
}
