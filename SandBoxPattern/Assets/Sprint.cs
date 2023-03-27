using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// one of the variances of sprinting, full sprint (child class)
public class Sprint : AthleticAbility
{
    public override void Activate()
    {

        // here is the different variation of the speed -> 4 
        Speed(4);
        Debug.Log("sprint");
    }
}
