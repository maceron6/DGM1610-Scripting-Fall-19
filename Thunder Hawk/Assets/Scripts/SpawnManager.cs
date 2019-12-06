using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    public float spawnX = 8f;
    public float spawnZ = 8f;
    public float height = 1f;
    public float interval = 1.5f;
    public float delay = 2f;
    private PlayerControll playerControlScript;
    private int kills;
    public TextMeshProUGUI Kills;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("enemySpawn", delay, interval);

        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControll>();

        kills = 0;
        Kills.text = "Kills: " + kills; 
        UpdateKills(1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void enemySpawn()
    {
        if(playerControlScript.youDied == false)
        {
            int orkPlanes = Random.Range(0, Prefabs.Length);

            Vector3 spawnPos = new Vector3 (Random.Range(-spawnX, spawnX), 1, spawnZ);

            Instantiate(Prefabs[orkPlanes], spawnPos, Prefabs[orkPlanes].transform.rotation);
        }
    }

    public void UpdateKills(int addKills)
    {
        kills += addKills;
        Kills.text = "Kills: " + kills;
    }
}
