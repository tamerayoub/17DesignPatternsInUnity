using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientVisitor : MonoBehaviour
{

    public PowerUp enginePowerUp;
    public PowerUp shieldPowerUp;
    public PowerUp weaponPowerUp;

    private BikeController bikeController;
    // Start is called before the first frame update
    void Start()
    {
        bikeController = gameObject.AddComponent<BikeController>();
    }

    private void OnGUI()
    {
        if (GUILayout.Button("PowerUp Shield"))
        {
            bikeController.Accept(shieldPowerUp);
        }
        if (GUILayout.Button("PowerUp Engine"))
        {
            bikeController.Accept(enginedPowerUp);
        }
        if (GUILayout.Button("PowerUp Weapon"))
        {
            bikeController.Accept(weapondPowerUp);
        }
    }


}
