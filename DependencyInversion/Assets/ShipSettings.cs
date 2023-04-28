using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Ship/Settings", fileName = "ShipData")]
public class ShipSettings : ScriptableObject
{

    // we keep these serialized private so other classes cannot write here
    [SerializeField] private float turnSpeed = 25f;
    [SerializeField] private float moveSpeed = 10f;
    [SerializeField] private bool useAi = false;
    
   

    public float TurnSpeed { get { return turnSpeed; } }

    public float MoveSpeed { get { return moveSpeed; } }

    public bool UseAi { get {  return useAi; } }
}


// our options we want to to adjust our pirate ship to