using System.IO;
using System.Text.RegularExpressions;
using System.Data;
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


        // string phrase = "My course";
        // char grade = 'A';
        // int age = 30;
        // double gpa = 0.3;
        // bool isMale = true;

        // Console.WriteLine("My\ncourse");
        // Console.WriteLine(phrase.Length);
        // Console.WriteLine(phrase.ToUpper());
        // Console.WriteLine(phrase.Contains("My"));
        // Console.WriteLine(phrase[0]);
        // Console.WriteLine(phrase.IndexOf("course"));clear
        // Console.WriteLine(phrase.IndexOf("o"));
        // Console.WriteLine(phrase.Substring(3, 6));
        // Console.WriteLine(Math.Sqrt(36));
        //     Console.ReadLine();

// Console.Write("Enter your name: ");
// string name = Console.ReadLine();
// Console.WriteLine("Hello "+ name);
// Console.Write("What is your are?");
// string age = Console.ReadLine();
// Console.WriteLine("Your age is "+ age);
// Console.ReadLine(); 

// Console.Write("Type a number: ");
// double num1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Type second number: ");
// double num2 = Convert.ToDouble(Console.ReadLine());
// Console.WriteLine(num1+num2);
// Console.ReadLine();

string colour, noun, celebrity;

Console.Write("Type a colour: ");
colour = Console.ReadLine();
Console.Write("Type a noun: ");
noun = Console.ReadLine();
Console.Write("Type a celebrity: ");
celebrity = Console.ReadLine();
Console.WriteLine("Roses are " + colour);
Console.WriteLine(noun + " are blue");
Console.WriteLine("I love " + celebrity);
Console.ReadLine();

        }
    }
}