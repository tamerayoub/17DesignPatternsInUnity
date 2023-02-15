using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : Command
{
    // Start is called before the first frame update
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
