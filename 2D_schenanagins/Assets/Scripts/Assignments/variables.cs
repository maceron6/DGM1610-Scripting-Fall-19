// PRAISE THE OMNISIAH
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// class is a warehouse to hold functions and varriables
// functions are machinery that do things in tha factory
// variables are containers for info
public class variables : MonoBehaviour
{
    string name = "Cam the Mighty";
    //strings use quotations
    int age = 25;
    //int is only intagers
    float height = 5.11f;
    //floats are for decimals, but make sure to add an "f" at the end
    bool married = false;
    //bools are for true/false questions




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("daft handle: " + name);
        Debug.Log("is " + age);
        Debug.Log("at " + height);
        Debug.Log("is he married " + married);
    }

    
}
// ctr + ? to auto comment
// PRAISE THE OMNISIAH