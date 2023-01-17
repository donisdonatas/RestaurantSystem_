using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class GenericClass<T>
    {

        //
        // https://dotnettutorials.net/lesson/list-collection-csharp/
        // https://dotnettutorials.net/lesson/generics-csharp/
        //

        public readonly List<T> ListOfVegetables = new List<T>();

        public GenericClass()
        {
           
            ListOfVegetables.Add("Kopūstas");
            //ListOfVegetables.Add("Bulvė");
            //ListOfVegetables.Add("Morka");
            //ListOfVegetables.Add("Žirniai");
            //ListOfVegetables.Add("Pupos");
            //ListOfVegetables.Add("Ridikėlis");
        }

        public void PrintList()
        {
            foreach(var vegetable in ListOfVegetables)
            {
                Console.WriteLine(vegetable);
            }
        }

        //public string[] ConvertToArray()
        //{
        //    return ListOfVegetables.ToArray();
        //}

        //public void Add(T value)
        //{
        //    ListOfVegetables.Add(value);
        //}

    }
}
