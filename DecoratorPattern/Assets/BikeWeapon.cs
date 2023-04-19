using UnityEngine;
using System.Collections;
using System;

public class BikeWeapon : MonoBehaviour
{
    public WeaponConfig weaponConfig;
    public WeaponAttachment mainAttachment;
    public WeaponAttachment secondaryAttachment;

    private bool isFiring;
    private IWeapon weapon;
    private bool isDecorated;

    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletSpeed; 


    void Start()
    {
        weapon = new Weapon(weaponConfig);
        bulletSpeed = weapon.Rate;
    }

    void OnGUI()
    {
        GUI.color = Color.green;

        GUI.Label(new Rect(5, 50, 200, 100), "Firing Rate: " + weapon.Rate);

        GUI.Label(new Rect(5, 70, 200, 100), "Range: " + weapon.Range);

        GUI.Label(new Rect(5, 90, 200, 100), "Strength: " + weapon.Strength);

        GUI.Label(new Rect(5, 110, 200, 100), "Cooldown: " + weapon.Cooldown);

        GUI.Label(new Rect(5, 130, 200, 100), "Weapon Firing: " + isFiring);

        if (mainAttachment && isDecorated)
            GUI.Label(new Rect(5, 170, 200, 100), "Main Attachment: " + mainAttachment.attachmentName);

        if (secondaryAttachment && isDecorated)
            GUI.Label(new Rect(5, 200, 200, 100), "Secondary Attachment: " + secondaryAttachment.attachmentName);
    }

    public void ToggleFire()
    {
        isFiring = !isFiring;

        if (isFiring)
            StartCoroutine(FireWeapon());
    }

    IEnumerator FireWeapon()
    {
        float firingRate = 10/weapon.Rate;
        bulletSpeed = firingRate;
        int index = 0;

        while (isFiring)
        {
            yield return new WaitForSeconds(firingRate);
            Debug.Log("fire " + index + " " + firingRate);
            var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletSpeed;
            index++;
        }
    }

    public void Reset()
    {
        weapon = new Weapon(weaponConfig);
        isFiring = false;
        isDecorated = !isDecorated;
    }

    public void Decorate()
    {
        isFiring = false;

        if (mainAttachment && !secondaryAttachment)
            weapon = new WeaponDecorator(weapon, mainAttachment);

        if (mainAttachment && secondaryAttachment)
            weapon = new WeaponDecorator(new WeaponDecorator(weapon, mainAttachment), secondaryAttachment);

        isDecorated = !isDecorated;
    }
}

