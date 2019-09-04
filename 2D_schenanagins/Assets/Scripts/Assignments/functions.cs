using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class functions : MonoBehaviour
{
    // string firstName;
    // string lastName;
    // int age;

    int num1;
    int num2;
    int total;
    

    // Start is called before the first frame update
    void Start()
    {
        // firstName = "Billbo";
        // lastName = "Baggins";
        // age = 111;
        // Customer(firstName, lastName, age);
        CalcAdd(11, 23);
    }
    
    // Update is called once per frame
    // try not to use for games
    int CalcAdd (int n1, int n2)
    {
        Debug.Log("#1 = " + n1 + "#2 = " + n2);
        total = n1 + n2;
        Debug.Log(total);
        return total;
        
    }

    // void Customer(string fName, string Name, int a)
    // {
    //     Debug.Log(fName + " " + lName + " " + a);
    // }
}
