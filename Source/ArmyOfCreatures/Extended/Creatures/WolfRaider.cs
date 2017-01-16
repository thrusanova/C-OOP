
namespace ArmyOfCreatures.Extended.Creatures
{
    using ArmyOfCreatures.Logic.Creatures;
    using Logic.Specialties;
    using Specialties;
    public class WolfRaider : Creature
    {
        public WolfRaider() : base(8,5,10,3.5m)
        {
            this.AddSpecialty(new DoubleDamage(7));
          //  this.AddSpecialty(new Hate(typeof(Griffin)));
        }
    }
}
