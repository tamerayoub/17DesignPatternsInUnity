using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Maze : MonoBehaviour
{
    public int height;
    public int width;
    public int cubeSize;
    int[,] arrayGrid;

    int x, z;
    public GameObject cube;
    void Start()
    {
        arrayGrid = new int[width, height];
        InstantiateCubes();
        Generate();
        DrawMap();
    }

    void InstantiateCubes()
    {

        for (z = 0; z < height; z++)
        {
            for (x = 0; x < width; x++)
            {
                arrayGrid[x, z] = 1;
            }
        }

    }

    void DrawMap()
    {

        for (z = 0; z < height; z++)
        {
            for (x = 0; x < width; x++)
            {
                if (arrayGrid[x, z] == 1)
                {
                    Vector3 pos = new Vector3((x - width / 2) * cubeSize, 1, ((z - height / 2) * cubeSize));
                    Instantiate(cube, pos, Quaternion.identity);
                }
            }
        }
    }
    void Generate()
    {
        int randomStPt = Random.Range(0, width);
        int x = randomStPt;
        int z = 0;
        int random = 0;

        arrayGrid[x, z] = 0;

        while (z < height - 1)
        {
            random = Random.Range(0, height);
            if (random < 25)
            {
                z = z + 1;
            }
            else if (random < 67)
            {
                if (x < width - 1 && x >= 0)
                {
                    x = x + 1;
                }
            }
            else
            {
                if (x < width - 1 && x >= 0)
                {
                    x = x - 1;
                }
            }
            arrayGrid[x, z] = 0;

        }

    }

}
