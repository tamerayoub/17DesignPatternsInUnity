using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// one of the variances of jumping, half jump(child class)
public class HalfJump : AthleticAbility
{
    public override void Activate()
    {

        // here is the different variation of the jump -> 4
        Jump(4);
        Debug.Log("half jump");
    }
}

