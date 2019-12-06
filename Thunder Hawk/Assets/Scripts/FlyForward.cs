using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyForward : MonoBehaviour
{
    public float flySpeed = 1.0f;
    public float strafeSpeed;
    private Rigidbody enemyRB;
    private GameObject player;
    private PlayerControll playerControlScript;
    // Start is called before the first frame update
    void Start()
    {
        enemyRB = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerControlScript = GameObject.Find("Player").GetComponent<PlayerControll>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * flySpeed);
        
        if (playerControlScript.youDied == false)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized;
            enemyRB.AddForce(lookDirection * strafeSpeed);
        }
    }

    
}
