using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private List<int> numbers = new List<int>() { 1, 2, 3, 4 , 5 , 6,  7, 8 , 9, 10 };

        public string getFullNameAndAge(string fn, string ln, int a)
        {
            return $"{fn} {ln}: {a}";
        }

        public int yearOfBirth(int age, int currentYear)
        {
            return currentYear - age;
        }

        public List<int> getNumbersByStep(List<int> list, int step)
        {
            List<int> result = new List<int>();
            foreach(int i in list)
            {
                if(i % step == 0)
                {
                    result.Add(i);
                }
            }
            return result;
        }
    }
}
