//using System;

//class Program
//{
//    static void Main()
//    {
//        // Using Console.Read
//        Console.Write("Enter a character: ");
//        int charCode = Console.Read();
//        Console.WriteLine("You entered (as int): " + charCode);
//        Console.WriteLine("You entered (as char): " + (char)charCode);

//        // Using Console.ReadLine
//        Console.Write("Enter a string: ");
//        string userInput = Console.ReadLine();
//        Console.WriteLine("You entered: " + userInput);
//    }
//}


using read_readline;
using System;

class Program
{
    static void Main()
    {
        //// Using Console.Read
        //Console.Write("Enter a character: ");
        //int charCode = Console.Read();
        //Console.WriteLine($"You entered (as int): {charCode}");
        //Console.WriteLine($"You entered (as char): {(char)charCode}");

        //// Clear the input buffer before reading a string
        //Console.ReadLine();

        //// Using Console.ReadLine
        //Console.Write("Enter a string: ");
        //string userInput = Console.ReadLine();
        //Console.WriteLine($"You entered: {userInput}");
    
            Dog myDog = new Dog();
            myDog.Bark();
            myDog.Eat();
        
    }

}

