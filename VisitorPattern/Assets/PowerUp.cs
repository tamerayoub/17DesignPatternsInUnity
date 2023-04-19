using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(Filename = "PowerUp", menuName = "PowerUp")]
public class PowerUp : ScriptableObject, IVisitor
{
    public string powerUpName;
    public GameObject powerUpPrefab;
    public string powerUpTypeDescription;


    [Tooltip("Fully heal shield")]
    public bool healShield;

    [Range(0.0f, 50.0f)]
    [Tooltip("Boost engine settings by turbo")]
    public float turboBoost;


    [Range(0.0f, 25.0f)]
    [Tooltip("Boost weapon range settings")]
    public int weaponRange;



    [Range(0.0f, 50.0f)]
    [Tooltip("Boost weapon strength settings")]
    public int weaponStrength;

    // 3 same name methods that accept different parameters, this is called overloading

    public void Visit(BikeEngine aBikeEngine)
    {
        float boost = aBikeEngine.turboBoost += turboBoost;

        if (boost < 0.0f)
        {
            aBikeEngine.turboBoost = 0.0f;
        }
        // check to make sure the new turboBoost from the powerup isnt greater than the maxiumum possible turboBoost

        if (boost >= aBikeEngine.maxTurboBoost)
        {
            aBikeEngine.turboBoost = aBikeEngine.maxTurboBoost;
        }
    }

    void Visit(BikeWeapon aBikeWeapon)
    {
        int range = aBikeWeapon.range += weaponRange; 


        // check to make sure the new range from the powerup isnt greater than the maxiumum possible range
        if (range >= aBikeWeapon.maxRange)
        {
            aBikeWeapon.range = aBikeWeapon.maxRange;
        }
        else
        {
            aBikeWeapon.range = range;
        }

        float strength = aBikeWeapon.strength += Mathf.Round(aBikeWeapon.strength * weaponStrength / 100);
        if (strength >= aBikeWeapon.maxStrength)
        {
            aBikeWeapon.strength = aBikeWeapon.maxStrength;
        }
        else
        {
            aBikeWeapon.strength = strength;
        }
    }

    void Visit(BikeShield aBikeShield)
    {
        if (healShield == true) { aBikeShield.health = 100.0f; }
    }


}
