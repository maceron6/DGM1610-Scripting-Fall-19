using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    public float xrange = 30f;
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
        
        horzInput = Input.GetAxis("Horizontal");

        vertInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horzInput * Time.deltaTime * speed);

        transform.Translate(Vector3.forward * vertInput * Time.deltaTime * speed);
    }
}
