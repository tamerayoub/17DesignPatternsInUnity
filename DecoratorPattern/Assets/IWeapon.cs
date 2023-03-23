using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeapon
{

    float Range { get ; }
   
    float Rate { get ; }
   
    float Strength { get ; }
   
    float Cooldown { get ; }
 
}
