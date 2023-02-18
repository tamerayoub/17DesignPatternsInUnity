using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
    private PlayerController controller;

    public MoveForward(PlayerController aController)
    {
        this.controller = aController;
    }
    public override void Execute()
    {
        this.controller.MoveForward();
    }

}
