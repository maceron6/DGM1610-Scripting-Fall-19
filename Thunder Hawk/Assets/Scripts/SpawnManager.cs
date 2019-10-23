using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float spawnX = 8f;
    public float spawnZ = 8f;
    public float interval = 1.5f;
    public float delay = 2f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemySpawn", delay, interval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enemySpawn()
    {
        int orkPlanes = Random.Range(0, Prefabs.Length);

        Vector3 spawnPos = new Vector3 (Random.Range(-spawnX, spawnX), 0, spawnZ);

        Instantiate(Prefabs[orkPlanes], spawnPos, Prefabs[orkPlanes].transform.rotation);
    }
}
