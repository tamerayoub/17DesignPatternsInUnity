using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDecorator : IWeapon
{

    private IWeapon decorateWeapon;
    private WeaponAttachment attachment;

    public WeaponDecorator(IWeapon weapon, WeaponAttachment anAttachment)
    {
        this.decoratedWeapon = aWeapon;
        this.attachment = anAttachment;
    }


    public float Range
    {
        get { return decoratedWeapon.range + attachment.Range; }
    }

    public float Rate
    {
        get { return decoratedWeapon.rate + attachment.Rate; }
    }

    public float Strength
    {
        get { return decoratedWeapon.strength + attachment.Strength; }
    }

    public float Cooldown
    {
        get { return decoratedWeapon.cooldown + attachment.Cooldown; }
    }

}
