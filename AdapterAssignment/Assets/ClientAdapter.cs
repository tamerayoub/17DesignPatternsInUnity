using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;

    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;


    void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdapter = new InventorySystemAdaptor();
    }


    void OnGUI()
    {
        if (GUILayout.Button("Add item (no adaptor)"))
        {
            inventorySystem.AddItem(item);
        }
        if (GUILayout.Button("Add item (with adaptor)"))
        {
            inventorySystemAdapter.AddItem(item, SaveLocation.Both);
        }
    }
}

