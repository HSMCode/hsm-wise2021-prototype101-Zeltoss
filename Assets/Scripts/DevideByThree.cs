using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevideByThree : MonoBehaviour
{
    public float variable1;
    public float variable2;
    public float variable3;
    public float variable4;
    public float variable5;

    private float result;

    // Prints the result in the console
    public string resultMessage = "Das Ergebnis lautet: ";

    // Adds up 5 Variables and divide them with 3
    void Start()
    {

      result = (variable1 + variable2 + variable3 + variable4 + variable5) / 3;
      //adds the result to the resultMessage
      Debug.Log(resultMessage + result);

    }
}
