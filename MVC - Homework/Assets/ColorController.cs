using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorController : ColorElement
{
    // Start is called before the first frame update


    public void RedColor()
    {

        app.model.colorRed = app.view.redView.GetComponent<Renderer>().material.GetColor("_Color");

        app.view.ball.GetComponent<Renderer>().material.color = app.model.colorRed;
    }
    public void LightBlueColor()
    {
        app.model.colorLightBlue = app.view.lightBlueView.GetComponent<Renderer>().material.GetColor("_Color");

        app.view.ball.GetComponent<Renderer>().material.color = app.model.colorLightBlue;
    }
    public void GreenColor()
    {

        app.model.colorGreen = app.view.greenView.GetComponent<Renderer>().material.GetColor("_Color");

        app.view.ball.GetComponent<Renderer>().material.color = app.model.colorGreen;
    }
    public void BlueColor()
    {

        app.model.colorBlue = app.view.blueView.GetComponent<Renderer>().material.GetColor("_Color");

        app.view.ball.GetComponent<Renderer>().material.color = app.model.colorBlue;
    }

    void OnGameComplete()
    {
        Debug.Log("victory!!!");
    }
}
