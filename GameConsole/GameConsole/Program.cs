using System;

namespace GameConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // InitTest();
            // NullConditionalOperator();
            // NullArrayValues();

            PlayerCharacter sarah = new PlayerCharacter(new DiamondSkinDefence())
            { 
                Name = "Sarah"
            };

            PlayerCharacter amrit = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Amrit"
            };

            PlayerCharacter gentry = new PlayerCharacter(SpecialDefence.Null)
            {
                Name = "Gentry"
            };

            sarah.Hit(10);
            amrit.Hit(10);
            gentry.Hit(10);
        }

        private static void InitTest()
        {
            /* var player = new PlayerCharacter();
            player.Name = "Sai";
            player.DaysSinceLastLogin = 42;

            PlayerDisplayer.Write(player); */
        }

        private static void NullArrayValues()
        {
            PlayerCharacter[] players = new PlayerCharacter[3]
            {
                null, // new PlayerCharacter { Name = "Sai" },
                null, // new PlayerCharacter(), // Name is Null
                null // PlayerCharacter is Null
            };

            // PlayerCharacter[] players = null;

            string p1 = players?[0]?.Name;
            string p2 = players?[1]?.Name;
            string p3 = players?[2]?.Name;
        }

        private static void NullConditionalOperator()
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
