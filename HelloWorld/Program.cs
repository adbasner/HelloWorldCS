using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Prints Hello World
            Console.WriteLine("Hello World!");
            int x = 89;
            Console.WriteLine(x);

            // Performs interpolation on output string
            int y = 20;
            double z = 30;
            Console.WriteLine("x = {0}; y = {1}", y, z);

            // Gets user in put - always a string
            string yourName;
            Console.WriteLine("What is your name");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);

            // Changes user input string to in, 32bit (standard)
            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You are {0} years old", age);

            // var can be implicit, must be initialized and assigned a value
            var word = "I am a word";
            // Error
            // var word;
            // word = "I am a word";

            // Constants
            const int two = 2;

            Console.WriteLine("The bird says {0}, the bird is {1} years old.", word, two);
        }
    }
}
