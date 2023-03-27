using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// one of the variances of jumping, full jump (child class)
public class FullJump : AthleticAbility
{
    public override void Activate()
    {

        // here is the different variation of the jumping -> 10
        Jump(10);
        Debug.Log("jump");
    }
}

