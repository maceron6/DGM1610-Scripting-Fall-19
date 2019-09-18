using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exsaustFollow : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(1.1f, 0.4f, -4.5f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // make the camera follow the bus
        transform.position = player.transform.position + offset;

    }
}