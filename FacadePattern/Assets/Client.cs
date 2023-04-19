using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    private ShipEngine shipEngine;
    // Start is called before the first frame update
    void Start()
    {
        shipEngine = gameObject.AddCompnent<shipEngine>();
    }

    private void  OnGUI()
    {
        if (GUI)
    }
}
