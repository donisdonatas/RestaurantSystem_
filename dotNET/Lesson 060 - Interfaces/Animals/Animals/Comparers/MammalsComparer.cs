using Animals.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Comparers
{
    public class MammalsComparer : IComparer<IMammal>
    {
        public int Compare(IMammal x, IMammal y )
        {
            return string.Compare(x.Name, y.Name );
        }
    }
}
