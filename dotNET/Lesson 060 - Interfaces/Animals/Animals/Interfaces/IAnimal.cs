﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Interfaces
{
    public interface IAnimal
    {
        string Name { get; }
        void Eat();
    }
}
