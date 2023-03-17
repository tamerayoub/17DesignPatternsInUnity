using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// this is the original file, we dont own this class and we're not allowed to change it, so must extend it usind the adapter pattern
// this uploads to the cloud, but we want to extend this and also upload to local storage but owners of this class sealed it, so apply adatper pattern
public class InventorySystem
{
    public void AddItem(InventoryItem anItem)
    {
        Debug.Log("Adding item to cloud");
    }

    public void RemoveItem(InventoryItem anItem)
    {
        Debug.Log("Remove item from the cloud");
    }

    public List<InventoryItem> GetInventory()
    {
        Debug.Log("Getting items from the cloud");
        return new List<InventoryItem>();
    }
}
