using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    HalfSprint halfSprint = new HalfSprint();
    Sprint sprint = new Sprint();


    GameController gameController;
    public GameObject usainBolt;
    public GameObject michaelJohnson;





    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            // usainBolt.transform.Translate(0, 0, 2);
            halfSprint.Activate();
        }
        if (Input.GetKeyDown("s"))
        {
            // michaelJohnson.transform.Translate(0, 0, 2);
            sprint.Activate();
        }
    }
}
