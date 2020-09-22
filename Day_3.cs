/*Interacting with the User*/

using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name= Console.ReadLine();
            var date= DateTime.Now;
            Console.WriteLine($"\nHello, {name}, on {date:d} at {date:t}!");
            Console.Write("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}

/*OUTPUT:

    What is your name?
    (Input: Aishani)

    Hello, Aishani, on 9/22/2020 at 6:16 PM!
    
*/
