using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class funkPractice : MonoBehaviour
{
    int num1;
    int num2;
    int total;
    string command = "GO";
    string action = "DIE";
    string location = "TO HELL";

    void Start()
    {
        CalcAdd(11, 23);
        CalcSub(10, 8);
        Calcmult(8, 3);
        Rage(command, action);
        Wrath(command, location);
    }
    
    int CalcAdd (int n1, int n2)
    {
        total = n1 + n2;
        return total;
    }

    int CalcSub(int n1, int n2)
    {
        total = n1 - n2;
        return total;
    }

    int Calcmult(int n1, int n2)
    {
        total = n1 * n2;
        return total;
    }

    void Rage(string comm, string act)
    {
        Debug.Log(comm + " " + act);
    }

    void Wrath(string comm, string loc)
    {
        Debug.Log(comm + " " + loc);
    }
}
