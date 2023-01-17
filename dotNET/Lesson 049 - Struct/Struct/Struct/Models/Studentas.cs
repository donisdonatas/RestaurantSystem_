using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Models
{
    public struct Studentas
    {
        public int id;
        public bool creditScore;

        public Studentas(int ID, bool cScore)
        {
            id = ID;
            creditScore = cScore;
        }
    }
}
