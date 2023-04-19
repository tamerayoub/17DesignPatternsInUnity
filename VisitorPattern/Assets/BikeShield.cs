using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeShield : MonoBehaviour
{
    // Start is called before the first frame update
    public float health = 50.0f;


    public  float Damage(float damage)
    {
        health = health - damage;
        return health;
    }


    public void Accept(IVisitor visitor)
    {

        visitor.Visit(this);
    }

    void OnGUI
    {
        GUI.color = Color.green;

        GUI.Label(new Rect(125, 0, 200, 20), "Shield health: " + health);
    }
}
