using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystemAdaptor : InventorySystem, IInventorySystem
{
    private List<InventoryItem> cloudInventory;

    public void SyncInventories()
    {
        var cloudInventory = GetInventory();
        Debug.Log("Downloading the cloud inventory");

    }

    public void AddItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            AddItem(anItem);
        }
        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to save to local drive");
        }
        if (aLocation == SaveLocation.Both)
        {
            Debug.Log("We need code here to save to both");
        }
    }

    public void RemoveItem(InventoryItem anItem, SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            RemoveItem(anItem);
        }
        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to remove from local drive");
        }
        if (aLocation == SaveLocation.Both)
        {
            RemoveItem(anItem);
            Debug.Log("We need code here to remove from both");
        }
    }


    public List<InventoryItem> GetInventory(SaveLocation aLocation)
    {
        if (aLocation == SaveLocation.Cloud)
        {
            GetInventory();
        }
        if (aLocation == SaveLocation.Local)
        {
            Debug.Log("We need code here to get the inventory from the local drive");
        }
        if (aLocation == SaveLocation.Both)
        {
            GetInventory();
            Debug.Log("We need code here to get the inventory from the local drive");
        }
        // this is a fake return, it doesn't do anything useful right now
        // It is a faux return statement

        // you will need to fix this line in your code, because nwo it literally does nothing
        return new List<InventoryItem>();
    }
}
