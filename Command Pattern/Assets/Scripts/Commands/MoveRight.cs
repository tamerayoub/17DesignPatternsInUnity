using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : Command
{
    private PlayerController controller;
    
    public MoveRight(PlayerController aController)
    {
        this.controller = aController;
    }
    public override void Execute()
    {
        this.controller.MoveRight();
    }
}
