using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Students
    {
        public string name;
        public string major;
        public double gpa;

        public Students (string aName, string aMajor, double aGpa) {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        public bool Honors () {
            if (gpa >= 3.5) {
                return true;
            } else {
                return false;
            }
        }
    }

}