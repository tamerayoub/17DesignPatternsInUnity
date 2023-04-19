using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{

    private List<IBikeElement> bikeElements = new List<IBikeELement>();
    // Start is called before the first frame update
    void Start()
    {
        bikeElements.Add(gameObject.AddComponent<BikeShield>());
        bikeElements.Add(gameObject.AddComponent<BikeEngine>());
        bikeElements.Add(gameObject.AddComponent<BikeWeapon>());
    }

    public void Accept(IVisitor aVisitor)
    {
        foreach(IBike)
    }
}
