
using UnityEngine;
using System;

public class WeaponDecorator : IWeapon
{
    private readonly IWeapon decoratedWeapon;
    private readonly WeaponAttachment attachment;

    public WeaponDecorator(IWeapon weapon, WeaponAttachment anAttachment)
    {
        this.decoratedWeapon = weapon;
        this.attachment = anAttachment;
    }

    public float Rate
    {
        get
        {
            return decoratedWeapon.Rate + attachment.Rate;
        }
    }

    public float Range
    {
        get
        {
            return decoratedWeapon.Range + attachment.Range;
        }
    }

    public float Strength
    {
        get
        {
            return decoratedWeapon.Strength + attachment.Strength;
        }
    }

    public float Cooldown
    {
        get
        {
            return decoratedWeapon.Cooldown + attachment.Cooldown;
        }
    }
}

