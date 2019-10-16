using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject pipePre;
    private Vector3 spawnPos = new Vector3 (25, 0, -4);
    public float spawnDelay = 2f;
    public float startDelay = 2f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", startDelay, spawnDelay);
    }

    // Update is called once per frame
    void SpawnPipe()
    {
        Instantiate(pipePre, spawnPos, pipePre.transform.rotation);
    }
}
