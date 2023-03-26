using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SpeedAbility
{
    public GameController gameController;

    public SpeedAbility(GameController controller)
    {
        gameController = controller;
    }


    public abstract void Activate();

    protected void Speed(float speed)
    {

        gameController.usainBolt.transform.Translate(0, 0, speed);

    }


}
