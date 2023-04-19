using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Monster
    {

        public string Name
        {
            get; set;
        }
        public int X
        {
            get; set;
        }
        public int Z
        {
            get; set;
        }
        public abstract int Hitpoints
        {
            get;
        }
        public abstract int ArmorClass
        {
            get;
        }
        public abstract int Strength
        {
            get;
        }
        public abstract int Speed
        {
            get;
        }
        public abstract double Damage
        {
            get;
        }
        public abstract double Attack
        {
            get;
        }

    }
}

