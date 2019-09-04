using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragon : MonoBehaviour
{
    string name = "Fatalis";
    int hp = 9999;
    float damage = 999.999f;
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
