using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Extensions
{
    public static class ReduceList
    {
        public static List<T> EveryOtherWord<T>(this List<T> List)
        {
            List<T> reducedList = new List<T>();
            for(int i = 0; i < List.Count; i++)
            {
                if(i % 2 == 0)
                {
                    reducedList.Add(List[i]);
                }
            }
            return reducedList;
        }
    }
}
