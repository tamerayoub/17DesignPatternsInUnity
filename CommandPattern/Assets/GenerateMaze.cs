using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{
    public void InstantiateMap()
    {

        int[,] array = new int[20, 20];

        for (int i = 0; i < 20; i++)
        {
            for (int j = 0; j < 20; j++)
            {
                array[i, j] = 1;
            }
        }


    }

    public void DrawMap()
    {





    }

    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        int width = 20;
        int height = 20; 
        int x = 0; 
        int z = 0; 

        while (z < height)
        {
            while (x < width)
            {
                Vector3 pos = new Vector3(x, 0, z);
                Instantiate(cube, pos, Quaternion.identity);
                x = x + 1;
            }
            z = z + 1;
            x = 0;
        }
    }     
    
    
    // Update is called once per frame
    void Update()
    {

    }
}