using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOOB : MonoBehaviour
{
    private float topBound = 30f;
    private float bottombound = -10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

        else if(transform.position.z < bottombound)
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
        }
    }
}
