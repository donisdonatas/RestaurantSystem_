using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Person
    {
        public string PersonName { get; set; }
        public List<Animal> Animals { get; set; } = new List<Animal>();

    }
}
