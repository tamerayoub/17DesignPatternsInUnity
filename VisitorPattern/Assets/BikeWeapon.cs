using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeWeapon : MonoBehaviour, IBikeElement
{
    [Header("Range")]
    public int range = 5;
    public int maxRange = 25;


    [Header("Strength")]
    public float strength = 25.0f;
    public float maxStrengh = 50.0f;


    public void Accept(IVisitor visitor)
    {

        visitor.Visit(this);
    }

    void OnGUI
    {

        GUI.color = Color.green;

        GUI.Label(new Rect(125, 0, 200, 20), "Weapon Range: " + range);
         
        GUI.Label(new Rect(125, 0, 200, 20), "Weapon Strength: " + strength);


    }
}
