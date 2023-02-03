using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlueView : ColorElement
{ 
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        app.controller.LightBlueColor();
    }
}
