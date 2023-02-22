using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 playerPos;

     private Vector3 playerPos1;
    private Vector3 playerPosEnd;
    private void Start() 
    {
        playerPos = this.gameObject.GetComponent<Transform>().position;
        Debug.Log(playerPos);
    }
    private void Update() {
        playerPos = this.gameObject.GetComponent<Transform>().position;
    }
    public void MoveLeft()
    {
        transform.Translate(Vector3.left);
    }
    public void MoveRight()
    {
        transform.Translate(Vector3.right);

    }
    public void MoveForward()
    {
        transform.Translate(Vector3.forward);

    }

     public void MoveBackward()
    {
        transform.Translate(Vector3.back);

    }


    public void ResetPosition()
    {
        transform.position = playerPos;

    }

   

    public void GetLastPos()
    {
       
            playerPos1 = playerPos; ;
    }

    public void PushLastPos() {
            transform.position = playerPos1;
    }


 


}
