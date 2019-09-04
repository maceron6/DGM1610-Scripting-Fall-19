using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villan : MonoBehaviour
{
    string name = "Algey";
    int hp = 200;
    float damage = 100.2f;
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
