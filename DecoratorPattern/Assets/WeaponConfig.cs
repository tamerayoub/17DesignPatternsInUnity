using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(filename = "NewWeaponConfig", menuName = "Weapon/Config".order = 1)]

public class WeaponConfig : ScriptableObject, IWeapon
{

    [Range(0, 100)]
    [Tooltip("Rate of firing per 10 seconds")]
    [SerializeField] private float rate;

    [Range(0, 100)]
    [Tooltip("Weapon Range")]
    [SerializeField] private float range;

    [Range(0, 100)]
    [Tooltip("Weapon Strength")]
    [SerializeField] private float strength;

    [Range(0, 100)]
    [Tooltip("Cooldown duration")]
    [SerializeField] private float rate;


    public float Range
    {
        get { return config.range; }
    }

    public float Rate
    {
        get { return config.rate; }
    }

    public float Strength
    {
        get { return config.strength; }
    }

    public float Cooldown
    {
        get { return config.cooldown; }
    }


}
