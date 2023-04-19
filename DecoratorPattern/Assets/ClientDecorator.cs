using UnityEngine;

public class ClientDecorator : MonoBehaviour
{
    private BikeWeapon bikeWeapon;
    private bool isWeaponDecorated;

    void Start()
    {
        bikeWeapon = (BikeWeapon) FindObjectOfType(typeof(BikeWeapon));
    }

    void OnGUI()
    {
        if (!isWeaponDecorated)
            if (GUILayout.Button("Decorate Weapon"))
            {
                bikeWeapon.Decorate();
                isWeaponDecorated = !isWeaponDecorated;
            }

        if (isWeaponDecorated)
            if (GUILayout.Button("Reset Weapon"))
            {
                bikeWeapon.Reset();
                isWeaponDecorated = !isWeaponDecorated;
            }

        if (GUILayout.Button("Toggle Fire"))
            bikeWeapon.ToggleFire();
    }
}

