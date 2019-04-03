using System;
namespace GameConsole
{
    public class NullDefence : SpecialDefence
    {
        public override int CalculateDamageReduction(int totalDamage)
        {
            return 0; // no operation
        }
    }
}
