using System.IO;
using System.Text.RegularExpressions;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
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

// string colour, noun, celebrity;
// Console.Write("Type a colour: ");
// colour = Console.ReadLine();
// Console.Write("Type a noun: ");
// noun = Console.ReadLine();
// Console.Write("Type a celebrity: ");
// celebrity = Console.ReadLine();
// Console.WriteLine("Roses are " + colour);
// Console.WriteLine(noun + " are blue");
// Console.WriteLine("I love " + celebrity);
// Console.ReadLine();

// int [] luckyNumbers = {2, 4, 15, 3, 68, 11};
// Console.WriteLine(luckyNumbers[5]);
// luckyNumbers [5] = 0;
// Console.WriteLine(luckyNumbers[5]);

// string [] names = new string [2];
// names [0] = "Olga";
// Console.WriteLine(names[0]);


// SayHi("Olga", 32);
// SayHi("Daniel", 33);
// SayHi("Ola", 32);
// Console.ReadLine();

// Console.WriteLine(Cube(5));

// bool isMale = true;
// bool isTall = false;
// if (isMale && isTall) {
//     Console.WriteLine("You are a tall male");
// } else if (isMale && !isTall){
//     Console.WriteLine("You are a short male");
// } else {
//     Console.WriteLine("You are not a tall male");
// }

// Console.Write("Enter a number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());
//             Console.Write("Enter a operator: ");
//             string op = Console.ReadLine();
//             Console.Write("Enter second number: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             if (op == "+") {
//                 Console.WriteLine(num1 + num2);
//             } else if (op == "-") {
//                 Console.Write(num1-num2);
//             } else if (op == "*") {
//                 Console.Write(num1*num2);
//             } else if (op == "/") {
//                 Console.Write(num1/num2);
//             } else {
//                 Console.WriteLine("Invalid operator");
//                 }


// Console.WriteLine(WeekDay(0));
// Console.ReadLine();

// int index = 6;
// while (index <=5) {
//     Console.WriteLine(index);
//     index ++;
// }

// do {
// Console.WriteLine(index);
//     index ++;
// } while (index <=5);
// }

// static void SayHi (string user, int age) {
    
//     Console.WriteLine("Hello " + user + ". Your age is " + age);
// }

// static int Cube (int num) {
//     int result = num * num * num;
//     return result;
// }

// static string WeekDay (int dayNum) {
//     string day;

// switch (dayNum) {
// case 0:
// day= "Sunday";
// break;
// case 1:
// day = "Monday";
// break;
// case 2:
// day= "Tuesday";
// break;
// case 3:
// day= "Wednesday";
// break;
// case 4:
// day= "Thursday";
// break;
// case 5:
// day= "Friday";
// break;
// case 6:
// day= "Saturday";
// break;
// default:
// day= "Invalid Day number";
// break;

// }
// return day;
// }

// GuessGame 
// string guessMyName = "Olga";
// string guess = "";
// bool outOfGuess = false;
// int guessCount = 0;
// int guessLimit = 3;

// while (guess != guessMyName && !outOfGuess) {
// if (guessCount < guessLimit) {
//     Console.WriteLine("Guess my name:");
//    guess = Console.ReadLine();
//     guessCount++;
// } else 
// {
// outOfGuess = true;
// }
// }
// if (outOfGuess) {
// Console.WriteLine("You lose :(");
// } else  {
// Console.WriteLine("You win!");
// }
    
// Foor Loop
// int [] luckyNumbers = {2, 4, 15, 3, 68, 11};
// for (int i=0; i < luckyNumbers.Length; i++ ) {
//     Console.WriteLine(luckyNumbers[i]);
// }

// Console.WriteLine(PowMethod(3,3));

//Try catch
// try {
// Console.Write("Type a number: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Type second number: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(num1/num2);
// Console.ReadLine();
// }
// catch (DivideByZeroException e) {
// Console.WriteLine(e.Message);
// }
// catch (FormatException e) {
//     Console.WriteLine(e.Message);
// }
// finally {
// Console.WriteLine("End");
// }

// Classes
//Book book1 = new Book("HP","JKR",400);
// book1.title = "HP";
// book1.author = "JKR";
// book1.pages = 400;

//Book book2 = new Book("LOTR","RRRRT",700);
// book2.title = "LOTR";
// book2.author = "RRRRT";
// book2.pages = 700;
//Console.WriteLine(book1.title);


//Students
// Students student1 = new Students ("Jim", "IT", 2.8);
// Students student2 = new Students ("Jil", "Art", 3.6);
// Console.WriteLine(student1.Honors());
// Console.WriteLine(student2.Honors());

//Movies
Movie avengers = new Movie ("Avengers", "Joss", "PG-13");
Movie shrek = new Movie ("Shrek", "Adam", "PG");

Console.WriteLine(avengers.Rate);
Console.WriteLine(shrek.Rate);
Console.ReadLine();
   }

//    static int PowMethod (int baseNum, int powNum) {
// int result = 1;

// for (int i = 0; i<powNum; i++) {
//     result = result * baseNum;
// }
// return result;
//    }

}
}