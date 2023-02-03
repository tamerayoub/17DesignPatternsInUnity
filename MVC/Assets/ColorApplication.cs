using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Coded by TamerAyoub

public class ColorElement: MonoBehaviour
{
    public ColorApplication app  {  get { return GameObject.FindObjectOfType<ColorApplication>(); } }

}


public class ColorApplication : MonoBehaviour
{
    // Start is called before the first frame update
    public ColorModel model;

    public ColorView view;

    public ColorController controller;

    void Start() { }
}
