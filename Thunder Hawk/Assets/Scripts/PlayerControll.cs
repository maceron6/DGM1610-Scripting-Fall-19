﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float xrange = 9.3f;
    public float horzInput;
    public float vertInput;
    public float speed = 10f;
    public GameObject projectilePref;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePref, transform.position, projectilePref.transform.rotation);
        }
        
        if(transform.position.x > xrange)
        {
            transform.position = new Vector3 (xrange, transform.position.y, transform.position.z);
        }

        if(transform.position.x < xrange)
        {
            transform.position = new Vector3 (-xrange, transform.position.y, transform.position.z);
        }

         horzInput = Input.GetAxis("Horizontal");

        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);
    }
}
