using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfSprint : SpeedAbility
{
    public override void Activate()
    {
        Speed(10);
        Debug.Log("half sprint");
    }
}

