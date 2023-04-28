using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PirateShipMotor : MonoBehaviour
{
    [SerializeField] private float turnSpeed = 15f;
    [SerializeField] private float moveSpeed = 10f;


    // The old way to do it
    // our ship motor is responsible for moving the ship; but its only input reading, which is breaking the single responsibility principle and has the dependancy GetAxis Horizontal
    // (which only works for the motor and not anything else like player) - so lets spread it out
    private void Update()
    {
        float rotation = Input.GetAxis("Horizontal");
        float thrust = Input.GetAxis("Vertical");
        transform.Rotate(Vector3.up * rotation * Time.deltaTime * turnSpeed);
        transform.position += transform.forward * thrust * Time.deltaTime * moveSpeed;
    }
}
