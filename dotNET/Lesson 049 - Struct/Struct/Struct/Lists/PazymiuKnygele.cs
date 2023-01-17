using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Lists
{
    public struct PazymiuKnygele
    {
        public int geografija;
        public int matematika;
        public int informatika;
        public int kunoKultura;
        public int uzsienioKalba;

        public PazymiuKnygele(int geog, int mat, int inf, int kk, int uzk)
        {
            geografija = geog;
            matematika = mat;
            informatika = inf;
            kunoKultura = kk;
            uzsienioKalba = uzk;
        }
    }
}
