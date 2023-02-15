using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private bool isRecording;
    private bool isReplaying;
    private PlayerController playerController;
    private Command buttonA, buttonD, buttonW, buttonW;

    void Start()
    {

        invoker = gameObject.AddComponent<Invoker>();
        this.playerController = FindObjectOfType<playerController>();

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

    void onGui()
    {
        if (GUILayout.Button("Start Recording"))
        {
            playerController.ResetPosition();
            isReplaying = false;
            isReplayingRecording = true;
            invoker.Record();
        }

        if (GUILayout.Button("Stop Recording"))
        {
            playerController.ResetPosition();
            isReplaying = false;
            isReplayingRecording = false;
            invoker.Record();
        }

        if (!isRecording)
        {

            if (GUILayout.Button("Start Replay"))
            {
                playerController.ResetPosition();
                isReplaying = true;
                isReplayingRecording = false;
                invoker.Replay();
            }

            // recording is recording what input the user is inputting
            // 

        }
    }
}
