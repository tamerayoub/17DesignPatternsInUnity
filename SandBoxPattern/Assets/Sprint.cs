using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : SpeedAbility
{
    public override void Activate()
    {
        Speed(20);
        Debug.Log("sprint");
    }
}
