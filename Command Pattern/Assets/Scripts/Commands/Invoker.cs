using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
using System.Threading;

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


        recordCommands.Clear(); // this refreshes the list new everytime you hit record
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

   
    for (int a = recordCommands.Count - 1; a >= 0; a--) {
            
             recordCommands[a].Undo(); 
             
            
    }
    
}
}