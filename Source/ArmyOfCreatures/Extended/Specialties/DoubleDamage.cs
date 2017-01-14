
namespace ArmyOfCreatures.Extended.Specialties
{
    using ArmyOfCreatures.Logic.Specialties;
    using Logic.Battles;
    using System;
    using System.Globalization;
    public class DoubleDamage:Specialty
    {
        private int rounds;

        public DoubleDamage(int rounds)
        {

            if (rounds <= 0)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be greater than 0");
            }
            if (rounds >= 10)
            {
                throw new ArgumentOutOfRangeException("rounds", "The number of rounds should be less than or equals to 10");
            }

            this.rounds = rounds;
        }
        public override decimal ChangeDamageWhenAttacking(
           ICreaturesInBattle attackerWithSpecialty,
           ICreaturesInBattle defender,
           decimal currentDamage)
        {
            if (attackerWithSpecialty == null)
            {
                throw new ArgumentNullException("attackerWithSpecialty");
            }

            if (defender == null)
            {
                throw new ArgumentNullException("defender");
            }
            if (this.rounds <= 0)
            {
                return 0;  
            }
            else
            {
                return currentDamage * 2;
                this.rounds--;

            }


        }
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "{0}({1})", base.ToString(),  this.rounds);
        }
    }
    
}
