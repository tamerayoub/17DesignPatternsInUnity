using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// the main parent class, this class will host the two abilities (jump and sprint), our child classes will send us 2 different variations for each of the abilities
public abstract class AthleticAbility
{
    // our activate function that we will call in the game controller when we press a certain key (linked to both parent and child classes)
    public abstract void Activate();


    // make sure this function is protected for child use
    protected void Sprint(float speed)
    {

        // our parent function that takes speed from its child classes, and moves the player forward accordingly 
        GameObject player;

        player = GameObject.FindWithTag("Usain Bolt");
        player.transform.Translate(0, 0, speed);


    }
    // make sure this function is protected for child use
    protected void Jump(float vertical)
    {

        // our parent function that takes speed from its child classes, and jumps the player
        GameObject player;

        player = GameObject.FindWithTag("Usain Bolt");
        player.GetComponent<Rigidbody>().AddForce(vertical * Vector3.up, ForceMode.VelocityChange);


    }


}
