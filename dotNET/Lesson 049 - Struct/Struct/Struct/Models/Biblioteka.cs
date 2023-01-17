using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Models
{
    public struct Biblioteka
    {
        public int Id;
        public string Name;
        public string PersonName;
        public int takenDate;

        public Biblioteka(int id, string bookName, string personName, int taken)
        {
            Id = id;
            Name = bookName;
            PersonName = personName;
            takenDate = taken;
        }

        public double getSienceBookTaken(int takenDate)
        {
            int today = 7;
            int daysBookTaken = (today - takenDate);
            return daysBookTaken;
        }
    }
}
