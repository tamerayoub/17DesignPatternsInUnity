using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Modified by Tamer Ayoub 3/26/23 ; I implemented the sandbox pattern in my code because I wanted different variations of sprinting, and different variations of jumping.
// I wanted a full sprint, and I wanted a half sprint. Sandbox pattern lets us implement different child variations of a parent function . A parent to child relationship
// with the parent defining the method, and the children defining different variations of the method.
public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    HalfSprint halfSprint = new HalfSprint();
    FullSprint fullSprint = new FullSprint();
    FullJump fullJump = new FullJump();
    HalfJump halfJump = new HalfJump();



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            // call the child half sprint class and activate a half sprint
            halfSprint.Activate();
        }
        if (Input.GetKeyDown("s"))
        {
            // call the child sprint class and activate a full sprint
            fullSprint.Activate();
        }
        if (Input.GetKeyDown("d"))
        {
            // call the child half jump class and activate a half jump
            halfJump.Activate();
        }
        if (Input.GetKeyDown("f"))
        {
            // call the child full jump class and activate a full jump
            fullJump.Activate();
        }

    }
}
