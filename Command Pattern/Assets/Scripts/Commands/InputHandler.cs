using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Invoker invoker;
    private bool isRecording;
    private bool isReplaying;
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
            // playerController.ResetPosition();
            isReplaying = false;
            isRecording = true;
            invoker.Record();
        }

        if (GUILayout.Button("Stop Recording"))
        {
            playerController.ResetPosition();
            isReplaying = false;
            isRecording = false;
        }


        if (!isRecording)
        {
            if (GUILayout.Button("Start Replaying"))
            {
                playerController.ResetPosition();
                isReplaying = true;
                isRecording = false;
                invoker.Replay();
            }
            if (GUILayout.Button("Reverse"))
            {
               isReplaying = true;
                isRecording = false;
                invoker.Reverse();
            }
        }
    }
}
