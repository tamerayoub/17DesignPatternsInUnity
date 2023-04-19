using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoolingSystem : MonoBehaviour
{


    public ShipEngine engine;
    public IEnumerable coolEngine;
    private bool isPaused;



    // Start is called before the first frame update
    void Start()
    {
        this.coolEngine = coolEngine();
    }
    

    public void PauseCooling()
    {
        this.isPaused = !this.isPaused;
    }

    public void ResetTemperature()
    {
        this.engine.currentTemp = 0.0f;
    }

    IEnumerator CoolEngine()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);

            if (!this.isPaused)
            {
                if (engine.currentTemp > engine.minTemp)
                {
                    engine.currentTemp = engine.currentTemp - engine.tempRate;
                }

                if (engine.currentTemp < engine.minTemp)
                {
                    engine.currentTemp = engine.currentTemp + engine.tempRate;
                }
            }


            else
            {

            }
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(100, 20, 500, 20), "Temp: " + engine.currentTemp);
    }

}
