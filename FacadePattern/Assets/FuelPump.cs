// Written By Jhhn
// 4/18/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuelPump : MonoBehaviour
{
    public ShipEngine engine;
    public IEnumerator burnFuel;


    // Start is called before the first frame update
    void Start()
    {
        burnFuel = BurnFuel();
    }

    IEnumerator BurnFuel()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            engine.fuelAmount = engine.fuelAmount - engine.burnRate;

            if(engine.fuelAmount <= 0.0f)
            {
                engine.TurnOff();
                yield return 0;
            }
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(100, 40, 500, 20), "Fuel: " + engine.fuelAmount);
    }

}
