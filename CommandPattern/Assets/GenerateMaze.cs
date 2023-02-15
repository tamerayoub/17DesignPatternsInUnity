using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateMaze : MonoBehaviour
{

    public int width = 100;
    public int height = 100;
    int[,] map = new int[100,100];
    public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        map = new int[width, height];
        InstantiateMap();
        map[0,0] = 0;
        Generate();
        DrawMap();

    }


    void InstantiateMap()
    {
        // fill a two dimensional array with all 1's
        int x = 0;
        int z = 0;

        while(z < 100)
        {
            while(x < 100)
            {
                map[x, z] = 1;
                x = x + 1;
                
            }
            
            z = z + 1;
            x = 0;
        }

    }
    void DrawMap()
    {
        // everywhere there is a 1, put a cube
        int x = 0;
        int z = 0;

        while (z < 100)
        {
            while (x < 100)
            {
                if(map[x, z] == 1)
                {
                    Vector3 pos = new Vector3(x, 0, z);
                    //GameObject wall = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    //wall.transform.position = pos;

                    Instantiate(cube, pos, Quaternion.identity);
                }
                x = x + 1;
            }
            z = z + 1;
            x = 0;
            
        }
    }

    void Generate()
    {
        // fill a two dimensional array with all 1's
        int x = width / 2;
        int z = 0;
       

        map[x, z] = 0;
        

        while (x != height && z!= width) {

            Random random = new Random();

            int randomNum = random.Next(1, 100);
            

            while (randomNum < 33)
            {
                map[x, z] = 0;
                z++;
            }

            while (randomNum > 33)
            {
                map[x, z] = 0;
                x++;
            }

            while (randomNum > 66 && randomNum < 100)
            {
                map[x, z] = 0;
                z++;
            }



        }




        
    }
}
