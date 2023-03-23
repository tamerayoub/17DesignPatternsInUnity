using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;


// this is our original class that needs to be adapted, this class saves Class Participants to a CSV file
public class SaveTo
{

    // this is the path where we are saving the save.csv file (saving on C drive doesnt work; we need permissions)
    private string path = "C:/Users/tamer/AppData/LocalLow/DefaultCompany/AdapterPattern/save.csv";


    // this function only saves to csv, we will adapt this to also save to json
    public void SaveString(List<string> data)
    {
        if (!File.Exists(path))
        {
            // create the file if it doesn't exist
            using (FileStream fs = File.Create(path))
            {


            }
        }

        // create a new StreamWriter object to write to the CSV file
        StreamWriter writer = new StreamWriter(path);

        // write each item in the list to the CSV file
        foreach (string item in data)
        {
            writer.WriteLine(item);
        }

        // close the StreamWriter object
        writer.Close();
    }


}
