using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MySelfMadeList<T>
    {
        private T[] MyArray { get; set; }
        private int Index = 0;
        private int Size = 10;

        public MySelfMadeList()
        {
            MyArray = new T[Size];
        }

        public void AddElement(T elementToAdd)
        {
            if(CheckIfFull())
            {
                MyArray = IncreaseListSize();
            }

            if(elementToAdd!= null)
            {
                MyArray[Index] = elementToAdd;
                Index++;
            }
            else
            {
                throw new ArgumentNullException(nameof(elementToAdd));
            }
        }

        private bool CheckIfFull()
        {
            if(Index == Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private T[] IncreaseListSize()
        {
            Size += (Size / 2);
            var newArray = new T[Size];
            MyArray.CopyTo(newArray, 0);
            return newArray;
        }

        public void DeleteElement(T elementToRemove)
        {
            MyArray = MyArray.Except(new T[] { elementToRemove }).ToArray();
        }

        public void Print()
        {
            foreach(T element in MyArray)
            {
                Console.WriteLine(element);
            }
        }
    }
}
