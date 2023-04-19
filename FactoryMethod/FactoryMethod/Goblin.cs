using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Goblin : Monster
    {
        public override int Hitpoints
        {
            get { return 10; }

        }
        public override int ArmorClass
        {
            get { return 15; }

        }
        public override int Speed
        {
            get { return 20; }
        }
        public override int Strength
        {
            get { return 10; }
        }
        public override double Damage
        {
            get { return Strength * 2; }

        }
        public override double Attack
        {
            get { return Strength + Speed; }
        }
    }
}
