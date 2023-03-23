using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyApp
{
    public class ItalianChef : Chef
    {
         public override void Special () {
            Console.WriteLine("Chef makes lazania");
        }
    }
}