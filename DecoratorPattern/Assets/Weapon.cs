using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : IWeapon
{
    private WeaponConfig config;

    public Weapon(WeaponConfig weaponConfig)
    {
        this.config = weaponConfig;
    }

    public float Range
    {
        get { return config.Range; }
    }

    public float Rate
    {
        get { return config.Rate; }
    }

    public float Strength
    {
        get { return config.Strength; }
    }

    public float Cooldown
    {
        get { return config.Cooldown; }
    }

}
