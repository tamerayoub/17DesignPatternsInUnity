using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(filename = "NewWeaponAttachment", menuName = "Weapon/Attachment".order = 1)]
public class WeaponAttachment : ScriptableObject, IWeapon
{
    [Range(0, 100)]
    [Tooltip("Weapon Range")]
    [SerializeField] private float range;

    [Range(0, 100)]
    [Tooltip("Weapon Strength")]
    [SerializeField] private float strength;

    [Range(-5, 5)]
    [Tooltip("Cooldown duration")]
    [SerializeField] private float rate;


    public string attachmentName;
    public string attachmentDescription;


    public float Range
    {
        get { return range; }
    }

    public float Rate
    {
        get { return rate; }
    }

    public float Strength
    {
        get { return strength; }
    }

    public float Cooldown
    {
        get { return cooldown; }
    }

}
