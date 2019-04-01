using System;
namespace GameConsole
{
    public class PlayerCharacter
    {
        public string Name { get; set; }
        public int DaysSinceLastLogin { get; set; }
        public DateTime DateOfBirth { get; set; }

        public PlayerCharacter()
        {
            DateOfBirth = DateTime.MinValue; // min value
            DaysSinceLastLogin = -1; // min value 
        }
    }
}
