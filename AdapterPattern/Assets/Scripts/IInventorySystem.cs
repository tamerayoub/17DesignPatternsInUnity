using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// This tell us how we wished the original class worked
// These methods are how we wish the original class was set up
public interface IInventorySystem
{
    void SyncInventories();
    void AddItem(InventoryItem anItem, SaveLocation aLocation);
    void RemoveItem(InventoryItem anItem, SaveLocation aLocation);
    List<InventoryItem> GetInventory(SaveLocation aLocation);
}
