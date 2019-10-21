﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Rigidbody playerRB;
    public float jumpForce;
    public float gravMod;
    public bool onGround = true;
    public bool gameOver = false;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
       // playerRB.AddForce(Vector3.up * 1000);
       Physics.gravity *= gravMod;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && onGround)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onGround = false;
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Ground"))
        {
            onGround = true;
        }

        else if (collision.gameObject.CompareTag("Pipe"))
        {
            gameOver = true;
            Debug.Log("YOU DIED");
        }
    }
}
