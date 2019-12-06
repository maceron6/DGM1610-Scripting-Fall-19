using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public AudioClip boom;
    private AudioSource killAudio;
    private GameObject spawnner;
    private SpawnManager spawnManager;
    // Start is called before the first frame update
    void Start()
    {
        killAudio = GetComponent<AudioSource>();
        spawnner = GameObject.Find("Spawnner");
        spawnManager = GameObject.Find("Spawnner").GetComponent<SpawnManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("enemy"))
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        killAudio.PlayOneShot(boom, 1.0f);
        spawnManager.UpdateKills(1);
        }

    }
}
