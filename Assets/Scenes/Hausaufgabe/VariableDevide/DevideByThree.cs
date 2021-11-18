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

    public string resultMessage = "Das Ergebnis lautet: ";

    // Start is called before the first frame update
    void Start()
    {

      result = (variable1 + variable2 + variable3 + variable4 + variable5) / 3;

      Debug.Log(resultMessage + result);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
