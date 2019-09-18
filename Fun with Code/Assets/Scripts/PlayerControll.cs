using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{

    //private float speed = 50.0f;
    private float turnSpeed;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        //it moves, whoopty doo :|
        transform.Translate(Vector3.forward * Time.deltaTime * forwardInput *25);
        //turn right or left
        //transform.Translate(Vector3.right * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.up, horizontalInput);
    }
}
