using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class InventorySystem
{
    // Start is called before the first frame update


    public void AddItem(InventoryItem anItem)
    {
        var filePath = "C:/inventory.csv";

        using (StreamWriter writer = new StreamWriter(filePath))
        {
            // write header row
            writer.WriteLine("Inventory Item");

            // write each item to a new row
            foreach (string item in InventoryItem)
            {
                writer.WriteLine(item);
            }
        }
    }



    public List<InventoryItem> GetInventory()
    {
        Debug.Log("Getting items from the cloud");
        return new List<InventoryItem>();
    }
}
