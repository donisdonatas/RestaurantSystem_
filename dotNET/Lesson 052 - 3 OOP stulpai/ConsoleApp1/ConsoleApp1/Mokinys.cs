using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Mokinys
    {
        public List<int> trimestras_1 = new List<int>();
        public List<int> trimestras_2 = new List<int>();
        public List<int> trimestras_3 = new List<int>();

        public float PirmoTrimestroVidurkis()
        {
            int pazymiuSuma = 0;
            foreach(int pazimys in trimestras_1)
            {
                pazymiuSuma += pazimys;
            }
            return pazymiuSuma/ (float)trimestras_1.Count;
        }

        public float AntroTrimestroVidurkis()
        {
            int pazymiuSuma = 0;
            foreach (int pazimys in trimestras_2)
            {
                pazymiuSuma += pazimys;
            }
            return pazymiuSuma / (float)trimestras_2.Count;
        }

        public float TrecioTrimestroVidurkis()
        {
            int pazymiuSuma = 0;
            foreach (int pazimys in trimestras_2)
            {
                pazymiuSuma += pazimys;
            }
            return pazymiuSuma / (float)trimestras_3.Count;
        }
    }
}
