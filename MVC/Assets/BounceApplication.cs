using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BounceElement: MonoBehaviour
{
    public BounceApplication app  {  get { return GameObject.FindObjectOfType<BounceApplication>(); } }

}


public class BounceApplication : MonoBehaviour
{
    // Start is called before the first frame update
    public BounceModel model;

    public BounceView view;

    public BounceController controller;

    void Start() { }
}
