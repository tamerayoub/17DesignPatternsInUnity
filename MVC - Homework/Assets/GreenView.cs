using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenView : ColorElement
{
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        app.controller.GreenColor();
    }
}
