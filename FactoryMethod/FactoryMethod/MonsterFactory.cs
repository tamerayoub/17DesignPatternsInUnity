using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class MonsterFactory
    {

        protected abstract Monster CreateMonster();
        public Monster MakeMonster()
        {
            // Make a monster
            Monster monster = CreateMonster();


            // now set the x and y location of the monster
            Random rnd = new Random();
            monster.X = rnd.Next(1, 100);
            monster.Z = rnd.Next(1, 100);
            return monster;
        }

    }
}
