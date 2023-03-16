using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientObjectPool : MonoBehaviour
{

    private DinoObjectPool pool;

    // Start is called before the first frame update
    void Start()
    {
        pool = gameObject.AddComponent<DinoObjectPool>();
    }

    // Update is called once per frame
    void OnGUI()
    {
        if (GUILayout.Button("Spawn Dinos"))
        {
            pool.Spawn();
        }
    }
}

// we put this script on the game object