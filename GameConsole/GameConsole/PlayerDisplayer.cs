using System;
namespace GameConsole
{
    public class PlayerDisplayer
    {
        public static void Write(PlayerCharacter player)
        {
            if (string.IsNullOrWhiteSpace(player.Name))
            {
                Console.WriteLine("Player name is null or all whitespace");
            }
            else
            {
                Console.WriteLine(player.Name);
            }

            // int days = player.DaysSinceLastLogin.GetValueOrDefault(-1);

            // Conditional Operator
            // int days = player.DaysSinceLastLogin.HasValue ? player.DaysSinceLastLogin.Value : -1;

            // Coalescing Operator
            int days = player.DaysSinceLastLogin ?? -1;

            Console.WriteLine($"{days} days since last login");

            /* if(player.DaysSinceLastLogin == null)
            {
                Console.WriteLine("No value for DaysSinceLastLogin");
            }
            else
            {
                Console.WriteLine(player.DaysSinceLastLogin);
            } */

            if (!player.DateOfBirth.HasValue)
            {
                Console.WriteLine("No value for DateOfBirth");
            }
            else
            {
                Console.WriteLine(player.DateOfBirth.Value);
            }

            if(player.IsNoob == null)
            {
                Console.WriteLine("Player newbie status is unknown");
            }
            else if (player.IsNoob == true)
            {
                Console.WriteLine("Player is a newbie");
            } else
            {
                Console.WriteLine("Player is experienced");
            }
        }
    }
}
