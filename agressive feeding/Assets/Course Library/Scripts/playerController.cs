using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    public float horizontalImput;
    private float speed = 20f;
    public float xrange = 22.0f;
    public GameObject projectilePrefab; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -xrange)
        {
            transform.position = new Vector3(-xrange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xrange)
        {
            transform.position = new Vector3(xrange, transform.position.y, transform.position.z);
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Dakka Dakka Dakka
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        horizontalImput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalImput * Time.deltaTime * speed);
    }
}
