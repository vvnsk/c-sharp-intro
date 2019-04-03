using System;

namespace GameConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            /* var player = new PlayerCharacter();
            player.Name = "Sai";
            player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player); */

            // NullConditionalOperator();

            NullArrayValues();

        }

        internal static void NullArrayValues()
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                new PlayerCharacter { Name = "Sai" },
                new PlayerCharacter(), // Name is Null
                null // PlayerCharacter is Null
            };

            // PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
        }


        internal static void NullConditionalOperator()
        {   
            PlayerCharacter player = null;

            //Null Conditional Operator

            int days = player?.DaysSinceLastLogin ?? -1;
            /* if(player != null)
            {
                days = player.DaysSinceLastLogin ?? -1;
            }
            else
            {
                days = -1;
            } */

            Console.WriteLine(days);
        }
    }
}
