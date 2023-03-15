using Internal;
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
        // string characterName = "John";
        // int characterAge = 35;
        
        //     Console.WriteLine("There was a man named " + characterName);
        //     Console.WriteLine(characterName + " was "+ characterAge);
        //     characterName = "Mike";
        //     Console.WriteLine(characterName + " liked beeing " + characterAge);


        string phrase = "My course";
        char grade = 'A';
        int age = 30;
        double gpa = 0.3;
        bool isMale = true;

        Console.WriteLine("My\ncourse");
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase.ToUpper());
        Console.WriteLine(phrase.Contains("My"));
        Console.WriteLine(phrase[0]);
        Console.WriteLine(phrase.IndexOf("course"));
        Console.WriteLine(phrase.IndexOf("o"));
        Console.WriteLine(phrase.Substring(3, 6));
         

            Console.ReadLine();
        }
    }
}