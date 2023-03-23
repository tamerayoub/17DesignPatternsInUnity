using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientAdapter : MonoBehaviour
{
    public InventoryItem item;
    private InventorySystem inventorySystem;
    private IInventorySystem inventorySystemAdapter;

    private SaveTo saveTo; // original class
    private ISaveTo saveToAdapter; // adapted class



    public List<string> data = new List<string>();


    void Start()
    {
        inventorySystem = new InventorySystem();
        inventorySystemAdapter = new InventorySystemAdaptor();

        saveTo = new SaveTo();
        saveToAdapter = new SaveToAdapter();

        data.Add("Class Participants");
        data.Add("Tamer Ayoub");
        data.Add("Qusai Fannoun");
        data.Add("Isaac Bustad");
        data.Add("Simen Restad");
        data.Add("Jonghyun Oh");
        data.Add("Ryan Hix-Wilking");
        data.Add("Luke Fradgley");
        data.Add("Much more..");
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

        if (GUILayout.Button("Add item to CSV file (no adapter)"))
        {
            saveTo.SaveString(data);
            Debug.Log("saved to CSV w/ no adapter");
        }

        if (GUILayout.Button("Add item to JSON file"))
        {
            saveToAdapter.SaveString(data, SaveLocation.JSON);

            Debug.Log("saved to Json w/ adapter");
        }
    }
}
