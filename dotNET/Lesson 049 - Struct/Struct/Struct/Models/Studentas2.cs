using Struct.Lists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Models
{
    public struct Studentas2
    {
        public List<PazymiuKnygele> pirmasSemestras;
        public List<PazymiuKnygele> antrasSemestras;
        public List<PazymiuKnygele> treciasSemestras;

        private List<PazymiuKnygele> uzpildytiPazymiuKnygele()
        {
            Random rnd = new Random();
            for(int i = 0; i < 5; i++)
            {
                pirmasSemestras.Add(rnd.Next(1, 11);
            }
        }
    }
}
