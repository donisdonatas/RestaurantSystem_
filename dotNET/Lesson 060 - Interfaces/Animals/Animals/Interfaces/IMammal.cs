using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Interfaces
{
    public interface IMammal
    {
        string Name { get; }
        void GiveBirth();
    }
}
