using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class Chef
    {
        public void Salad () {
            Console.WriteLine("Chef makes salad");
        }

          public virtual void Special () {
            Console.WriteLine("Chef makes pasta");
        }
    }
}