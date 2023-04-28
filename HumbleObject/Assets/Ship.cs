using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    [SerializeField] private ShipSettings shipSettings;
    private IShipInput shipInput;
    private PirateShipMotorV3 pirateShipMotorV3;


    // In awake, this is like bootstrap where we create the object and prepare everything, we have this one spot where the ship prepares itself
    // What kind of settings does it want, AI or a Controller
    // It checks what the user selected in the ship settings file
    private void Awake()
    {
        shipInput = shipSettings.UseAi ? new AiInput() as IShipInput : new ControllerInput();
        pirateShipMotorV3 = new PirateShipMotorV3(shipInput, transform, shipSettings);
    }

    // On update, run the tick method so our boat can move; depending on if the user selected AI or the Normal Controller, on update we will be reading movement/thrust controls
    private void Update()
    {
        shipInput.ReadInput();
        pirateShipMotorV3.Tick();
    }
}
