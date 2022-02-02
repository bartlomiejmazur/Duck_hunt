using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;
    public float spawnRate = 2f;
    float nextSpawn = 0.0f;
    

    void Start()
    {
        
        spawnObject();
    }

    void Update()
    {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + spawnRate;
            spawnObject();
        }
    }
    public void spawnObject()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(-20f, -10f);
            screenY = Random.Range(-3f, 3f);
            pos = new Vector2(screenX, screenY );
            Instantiate(toSpawn, pos,Quaternion.identity, GameObject.FindGameObjectWithTag("Spawn").transform);
            
        }
    }
}
