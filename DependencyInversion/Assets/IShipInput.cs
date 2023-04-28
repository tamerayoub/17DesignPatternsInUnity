using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IShipInput
{
    void ReadInput(); // anything that implements this will have to have this
    float Rotation { get; } // rotation and thrust, anything that implements that must return a rotation and a thrust
    float Thrust { get; }
}
