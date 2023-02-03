using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedView : ColorElement
{
    // Start is called before the first frame update
    void OnCollisionEnter()
    {
        app.controller.RedColor();
    }
}
