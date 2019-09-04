using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toon : MonoBehaviour
{
    string name = "Walter";
    int hp = 1;
    float damage = 0.001f;
    bool canFly = true;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("name: " + name);
        Debug.Log("hp: " + hp);
        Debug.Log("Damage: " + damage);
        Debug.Log("Fly? " + canFly);
    }
   
}
