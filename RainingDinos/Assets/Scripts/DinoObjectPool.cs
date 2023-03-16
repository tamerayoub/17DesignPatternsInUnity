using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

public class DinoObjectPool : MonoBehaviour
{

    public int maxPoolSize = 20;
    public int StackDefaultCapacity = 20;
    public IObjectPool<Dino> pool;
    // Before I added the prefab through the inspector thus the myPrefab
    // but down below I actually grabbed it from the Resources folder
    //public GameObject myPrefab;

    public IObjectPool<Dino> Pool
    {
        get
        {
            if (pool == null)
                pool = new ObjectPool<Dino>(
                        CreatedPooledItem,
                        OnTakeFromPool,
                        OnReturnedToPool,
                        OnDestroyPoolObject,
                        true,
                        StackDefaultCapacity,
                        maxPoolSize);

            return pool;
        }

    }

    private Dino CreatedPooledItem()
    {
        GameObject go = Instantiate(Resources.Load("Raptor", typeof(GameObject))) as GameObject;

        Dino dino = go.AddComponent<Dino>();

        go.name = "Dino";
        dino.Pool = Pool;
        return dino;
    }

    private void OnReturnedToPool(Dino dino)
    {
        dino.gameObject.SetActive(false);
    }

    private void OnTakeFromPool(Dino dino)
    {
        dino.gameObject.SetActive(true);
    }

    private void OnDestroyPoolObject(Dino dino)
    {
        Destroy(dino.gameObject);
    }

    public void Spawn()
    {
        var amount = Random.Range(1, 10);

        for (int i = 0; i < amount; i++)
        {
            var dino = Pool.Get();

            dino.transform.position = Random.insideUnitSphere * 10;
        }
    }
}


// this script handles spawning, creating, returning to pool, taking from pool, and destroying it after