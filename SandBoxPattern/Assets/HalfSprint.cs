using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// one of the variances of sprinting, half sprint (child class)
public class HalfSprint : AthleticAbility
{
    public override void Activate()
    {

        // here is the different variation of the speed -> 1
        Sprint(1);
        Debug.Log("half sprint");
    }
}

