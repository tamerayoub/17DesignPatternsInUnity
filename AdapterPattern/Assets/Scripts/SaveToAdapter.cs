using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

// this class is our new SaveTo class where we adapted the SaveString function to now save JSON if we like
public class SaveToAdapter : SaveTo, ISaveTo
{

    public void SaveString(List<string> data, SaveLocation aLocation)
    {

        // if save location is CSV
        if (aLocation == SaveLocation.CSV)
        {
            SaveString(data);
        }

        // if save location is JSON
        if (aLocation == SaveLocation.JSON)
        {
            string filePath = "C:/Users/tamer/AppData/LocalLow/DefaultCompany/AdapterPattern/save.json";

            if (!File.Exists(filePath))
            {
                // create the file if it doesn't exist
                using (FileStream fs = File.Create(filePath))
                {
                }
            }

            // convert the list to a JSON string
            string json = JsonConvert.SerializeObject(data);
            // create a new StreamWriter object to write to the JSON file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                // write the JSON string to the JSON file
                writer.Write(json);
                writer.Flush();
                writer.Close();
            }
        }
    }

}
