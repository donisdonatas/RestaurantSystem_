using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Models
{
    public struct Staciakampis
    {
        public int ilgis;
        public int plotis;
        
        public Staciakampis(int il, int pl)
        {
            ilgis = il;
            plotis = pl;
        }

        public int getArea()
        {
            return ilgis * plotis;
        }
    }

    
    
}
