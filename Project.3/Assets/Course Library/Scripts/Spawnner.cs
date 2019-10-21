using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnner : MonoBehaviour
{
    public GameObject pipePre;
    private Vector3 spawnPos = new Vector3 (25, 0, -4);
    public float spawnDelay = 2f;
    public float startDelay = 2f;
    private PlayerControl playerControllscript;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPipe", startDelay, spawnDelay);
        playerControllscript = GameObject.Find("Player").GetComponent<PlayerControl>();
    }

    // Update is called once per frame
    void SpawnPipe()
    {
        

        if(playerControllscript.gameOver == false)
        {
            Instantiate(pipePre, spawnPos, pipePre.transform.rotation);
        }
    }
}
