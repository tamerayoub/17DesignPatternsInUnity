using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipEngine : MonoBehaviour
{
    public float burnRate = 1.0f;
    public float fuelAmount = 100.0f;
    public float tempRate = 5.0f;
    public float minTemp = 50.0f;
    public float maxTemp = 65.0f;
    public float currentTemp = 0.0f;
    public float turboDuration = 2.0f;

    private bool isEngineOn;
    private FuelPump fuelPump;
    private TurboCharger turboCharger;
    private CoolingSystem coolingSystem;


    private void Awake()
    {
        fuelPump = gameObject.AddComponent<FuelPump>();
        turboCharger = gameObject.AddComponent<TurboCharger>();
        coolingSystem = gameObject.AddComponent<CoolingSystem>();
    }

    // Start is called before the first frame update
    void Start()
    {
        fuelPump.engine = this;
        turboCharger.engine = this;
        coolingSystem.engine = this;
    }

    public void TurnOn()
    {
        isEngineOn = true;
        StartCoroutine(fuelPump.burnFuel);
        StartCoroutine(coolingSystem.coolEngine);
    }

    public void TurnOff()
    {
        isEngineOn = false;
        StopCoroutine(fuelPump.burnFuel);
        StopCoroutine(coolingSystem.coolEngine);
    }

    public void ToggleTurbo()
    {
        if (isEngineOn)
        {
            turboCharger.ToggleTurbo(coolingSystem);
        }
    }

    private void OnGUI()
    {
        GUI.color = Color.green;
        GUI.Label(new Rect(100, 0, 500, 20), "Engine Running: " + isEngineOn);
    }

}
