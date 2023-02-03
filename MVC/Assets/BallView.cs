using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallView : BounceElement
{
    // Start is called before the first frame update
    
    // void means it doenst return anything
    void OnCollisionEnter()
    {
        app.controller.OnBallGround();
    }

    
}
