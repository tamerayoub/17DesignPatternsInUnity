using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    private PlayerController controller;


    public MoveLeft(PlayerController aController)
    {
        this.controller = aController;
    }

    public override void Execute()
    {
        this.controller.MoveLeft();
    }



}
