using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateShipMotorV2 : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private float moveSpeed = 10f;

    // no constructors on monoBehavior
  /*  private IShipInput shipInput; */
    

    private void Awake()
    {

     /*   shipInput = GetComponent<IShipInput>();*/

    }
    private void Update()
    {


    //  this is how we fix our dependancy issue; seperating everything out
    /*  float rotation = shipInput.Rotation;*/
    /*  float thrust = shipInput.Thrust;*/
    /*  transform.Rotate(Vector3.up * rotation * Time.deltaTime * turnSpeed);*/
    /*  transform.position += transform.forward * thrust * Time.deltaTime * moveSpeed;*/
    }
}
