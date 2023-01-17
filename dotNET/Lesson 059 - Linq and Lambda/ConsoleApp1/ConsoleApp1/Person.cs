using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public List<Person> Persons = new List<Person>();
        public string Name { get; set; }
        public int Age { get; set; }

        public void CreatePersonsList()
        {
            Person person1 = new Person();
            person1.Name = "Bill";
            person1.Age = 10;
            Persons.Add(person1);

            Person person2 = new Person();
            person2.Name = "Ally";
            person2.Age = 12;
            Persons.Add(person2);

            Person person3 = new Person();
            person3.Name = "Micke";
            person3.Age = 15;
            Persons.Add(person3);

            Person person4 = new Person();
            person4.Name = "Angel";
            person4.Age = 19;
            Persons.Add(person4);

            Person person5 = new Person();
            person5.Name = "Patric";
            person5.Age = 42;
            Persons.Add(person5);

            Person person6 = new Person();
            person6.Name = "Denzel";
            person6.Age = 45;
            Persons.Add(person6);
        }
    }
}
