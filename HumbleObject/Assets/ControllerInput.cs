using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerInput : IShipInput
{
    // We will have our controller in charge of checking when to rotate and thrust our pirate ship 
    public void ReadInput()
    {
        Rotation = Input.GetAxis("Horizontal");
        Thrust = Input.GetAxis("Vertical");
    }

    public float Rotation { get; private set; } // since its private, we cannot set rotation and thrust outside of here
    public float Thrust { get; private set;}
}
