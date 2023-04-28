using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This is the way to do it with Dependancy Inversion; this class is not in charge of going out and finding its dependancies, its only receiving them
public class PirateShipMotorV3 
{
    private readonly IShipInput shipInput;
    private readonly Transform transformToMove;
    private readonly ShipSettings shipSettings;


    // the main goal is to pass in your dependancies, instead having to go out and find them (dependancy injection)
    public PirateShipMotorV3(IShipInput shipInput, Transform transformToMove, ShipSettings shipSettings)
    {

        this.shipInput = shipInput;
        this.transformToMove = transformToMove;
        this.shipSettings = shipSettings;
    }

    // were getting our shipinput from somehwere else; so our ship motor is only responsible for moving without having to know the settings and doesnt have to be monobevaior
    // 
    public void Tick()
    {
        transformToMove.Rotate(Vector3.up * shipInput.Rotation * Time.deltaTime * shipSettings.TurnSpeed);
        transformToMove.position += transformToMove.forward * shipInput.Thrust * Time.deltaTime * shipSettings.MoveSpeed;
    }
}
