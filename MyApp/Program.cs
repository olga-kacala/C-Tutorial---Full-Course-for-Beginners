using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panda
{
    class Program
    {
        static void Main(string[] args)
        {
        string characterName = "John";
        int characterAge = 35;
        
            Console.WriteLine("There was a man named " + characterName);
            Console.WriteLine(characterName + " was "+ characterAge);
            characterName = "Mike";
            Console.WriteLine(characterName + " liked beeing " + characterAge);

            Console.ReadLine();
        }
    }
}