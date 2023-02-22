using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private bool isRecording;
    private bool isReplaying;
    private bool isReversed;
    private PlayerController playerController;
    private Command buttonA, buttonD, buttonW;

    void Start()
    {
        this.invoker = gameObject.AddComponent<Invoker>();
        this.playerController = FindObjectOfType<PlayerController>();

        this.buttonA = new MoveLeft(playerController);
        this.buttonD = new MoveRight(playerController);
        this.buttonW = new MoveForward(playerController);
    }
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.A))
        {
            invoker.ExecuteCommand(buttonA);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            invoker.ExecuteCommand(buttonD);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            invoker.ExecuteCommand(buttonW);
        }
    }

    private void OnGUI()
    {
        if (GUILayout.Button("Start Recording"))
        {
            
            isReplaying = false;
            isRecording = true;
            
             isReversed = false;
            invoker.Record();

            playerController.GetLastPos();

        }

        if (GUILayout.Button("Stop Recording"))
        {
          
            isReplaying = false;
            isRecording = false;
            isReversed = false;

          
            
        }


        if (!isRecording)
        {
            if (GUILayout.Button("Start Replaying"))
            {
            
                isReplaying = true;
                isRecording = false;
                isReversed = false;
                
                invoker.Replay();
            }
            if (GUILayout.Button("Reverse"))
            {
                
                isReplaying = false;
                isRecording = false;
                isReversed = false;
                invoker.Reverse();
            }
           
        }
    }
}
