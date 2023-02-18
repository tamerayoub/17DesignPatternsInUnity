using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoker : MonoBehaviour
{
    private bool isRecording;
    private bool isReplaying;
    private List<Command> recordCommands = new List<Command>();
    public void ExecuteCommand(Command aCommand)
    {
        aCommand.Execute();
        if (isRecording)
        {
            recordCommands.Add(aCommand);
        }
        Debug.Log("Recording Command: " + aCommand);
    }
    public void Record()
    {
        isRecording = true;
    }
    public void Replay()
    {
        isReplaying = true;
        if (recordCommands.Count <= 0)
        {
            Debug.Log("There is nothing to replay");
        }
        else
        {
            foreach (var command in recordCommands)
            {
                command.Execute();
                Debug.Log("Executing Command: " + command);
            }
            isReplaying = false;
        }
    }

    public void Reverse()
    {

    }
}
