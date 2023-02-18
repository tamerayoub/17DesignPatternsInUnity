using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Vector3 playerPos;
    private void Start()
    {
        playerPos = this.gameObject.GetComponent<Transform>().position;
        Debug.Log(playerPos);
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
    public void ResetPosition()
    {
        transform.position = playerPos;

    }
}
