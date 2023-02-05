using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private Renderer renderedObject;

    void Awake()
    {
        renderedObject = GetComponent<Renderer>();
        propBlock = new MaterialPropertyBlock();
    }

    // Update is called once per frame
    

    private Color GetRandomColor()
    {
        return new Color(
            Random.Range(0f, 1f),
             Random.Range(0f, 1f),
            Random.Range(0f, 1f)
            );
    }

    private MaterialPropertyBlock propBlock;


    void Update()
    {
        renderedObject.GetPropertyBlock(propBlock);
        propBlock.SetColor("_Color", GetRandomColor());
        renderedObject.SetPropertyBlock(propBlock);
    }
}
