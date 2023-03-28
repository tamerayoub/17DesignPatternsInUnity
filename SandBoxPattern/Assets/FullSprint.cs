using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// one of the variances of sprinting, full sprint (child class)
public class FullSprint : AthleticAbility
{
    public override void Activate()
    {

        // here is the different variation of the speed -> 4 
        Sprint(4);
        Debug.Log("sprint");
    }
}
