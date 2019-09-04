using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero : MonoBehaviour
{
    string name = "Robart";
    int hp = 100;
    float damage = 13.1f;
    bool canFly = false;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("name: " + name);
        Debug.Log("hp: " + hp);
        Debug.Log("Damage: " + damage);
        Debug.Log("Fly? " + canFly);
    }
}
