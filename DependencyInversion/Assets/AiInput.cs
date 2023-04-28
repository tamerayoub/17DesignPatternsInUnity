using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiInput : IShipInput
{
    // Incorporates random values to make the AI ship move
    public void ReadInput()
    {
        Rotation = Random.Range(-1f, 1f);
        Thrust = Random.Range(0, 1f);
    }

   public float Rotation { get; private set; }
   public float Thrust { get; private set;}
}
