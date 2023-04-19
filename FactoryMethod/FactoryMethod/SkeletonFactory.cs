using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class SkeletonFactory : MonsterFactory
    {

        // override overrides a previous method like the Monster CreateMonster in Monseter Factory 
        protected override Monster CreateMonster()
        {
            return new Skeleton();
        }
    }
}
