using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct.Models
{
    public struct Mokinys
    {
        public string firstName;
        public string lastName;
        public int startOfCourses;
        public int finishOfCourses;

        public Mokinys(string fn, string ln, int startOfCrs, int finishOfCrs)
        {
            firstName = fn;
            lastName = ln;
            startOfCourses = startOfCrs;
            finishOfCourses= finishOfCrs;
        }
    }
}
