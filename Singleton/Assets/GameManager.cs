using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class GameManager : Singleton<GameManager>
{
    // Start is called before the first frame update

    private DateTime sessionStartTime;
    private DateTime sessionEndTime;

    void Start()
    {
        // In here initialize whatever variables you need to track 
        // such as score or level or health ect.
        // we are using time 
        sessionStartTime = DateTime.Now;
        Debug.Log("Game session start : " + DateTime.Now);
    }

    void OnApplicationQuit()
    {
        sessionEndTime = DateTime.Now;

        TimeSpan timeDifference = sessionEndTime.Subtract(sessionStartTime);

        Debug.Log("Game Session ended at: " + DateTime.Now);
        Debug.Log("Game Session ended at: " + timeDifference);
    }

    void OnGUI()
    {
        if (GUILayout.Button("Next Scene"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
