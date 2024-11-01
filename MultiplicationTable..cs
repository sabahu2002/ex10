using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Multiplication Table of 5");

        // for loop to call the function
        for (int i=1; i<=10; i++)
        {
            Debug.Log("5 x " + i + " = " + " " + Multiply(i,5));

        }
        
    }

   
//Function of multiplication
int Multiply (int num1, int num2)
   {
    int multy=num1*num2;
    return multy;
   }
}