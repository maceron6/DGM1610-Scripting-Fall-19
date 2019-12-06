using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapLoop : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;
    public float flySpeed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        repeatWidth = GetComponent<BoxCollider>().size.z / 0.734f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * flySpeed);
        if (transform.position.z < startPos.z -repeatWidth)
        {
            transform.position = startPos;
        }
    }
}
