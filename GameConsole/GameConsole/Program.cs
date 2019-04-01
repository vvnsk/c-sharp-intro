using System;

namespace GameConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var player = new PlayerCharacter();
            player.Name = "Sai";
            player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player);

            Console.ReadLine();
        }
    }
}
