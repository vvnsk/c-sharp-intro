using System;

namespace Hello
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            // Console.WriteLine("Hello" + " World!");

            // Console.WriteLine("Hello " + args[0]);

            Console.WriteLine("Your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("How many hours of sleep did you get last night?");
            int hoursOfSleep = int.Parse(Console.ReadLine());

            Console.WriteLine("Hello " + name + "!");

            if(hoursOfSleep > 8) {
                Console.WriteLine("You are well rested");
            } else {
                Console.WriteLine("You need more sleep");
            }
        }
    }
}
