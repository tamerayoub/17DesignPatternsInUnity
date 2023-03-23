using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipWeapon : MonoBehaviour
{

    public WeaponConfig weaponConfig;

    // here is where you would add in multiple attachments, we will only have two
    public WeaponAttachment mainAttachment;
    public WeaponAttachment secondaryAttachment;
    // Start is called before the first frame update

    private bool isFiring;
    private IWeapon weapon;
    private bool isDecorated;

    void Start()
    {
        this.weapon = new Weapon(weaponConfig);
    }

    void OnGUI()
    {
        OnGUI().color = Color.green;

        GUI.Label(new Rect(5, 50, 200, 100), "Firing Rate: " + weapon.Rate);

        GUI.Label(new Rect(5, 70, 200, 100), "Range: " + weapon.Range);

        GUI.Label(new Rect(5, 90, 200, 100), "Range: " + weapon.Range);

        GUI.Label(new Rect(5, 110, 200, 100), "Strength: " + weapon.Strength);

        GUI.Label(new Rect(5, 130, 200, 100), "Cooldown: " + weapon.Cooldown);
    }


    if (mainAttachment && isDecorated)
    {
        OnGUI().Label(new Rect(5, 170, 200, 100), "Main Attachment: " + mainAttachment.attachmentName);

    }


if (secondaryAttachment && isDecorated)
{
    OnGUI().Label(new Rect(5, 200, 200, 100), "Main Attachment: " + mainAttachment.attachmentName);

}

public void ToggleFire()
{
    isFiring = !isFiring;

    if (isFiring)
    {
        StartCoroutine(FireWeapon());
    }
}
// Update is called once per frame
void Update()
{

}

IEnumerator Fireweapon()
{
    float firingRate = 10 / weaponRate;


    while (isFiring)
    {
        yield return new WaitForSeconds(firingRate);

        Debug.Log("fire " + firingRate);
    }
}

public void Reset()
{
    weapon = new Weapon(weaponConfig);
    isFiring = false;
    isDecorated = false;
}


public void Decorate()
{
    isFiring = false;

    if (mainAttachment && !secondaryAttachment)
    {
        Weapon = new WeaponDecorator(weapon, mainAttachment)
        }

    if (mainAttachment && secondaryAttachment)
    {
        Weapon = new WeaponDecorator(new WeaponDecorator(weapon, mainAttachment), secondaryAttachment);
    }

    isDecorated = !isDecorated;

}


}
