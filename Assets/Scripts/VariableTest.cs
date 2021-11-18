using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableTest : MonoBehaviour
{

    public int myFirstInteger;
    public int mySecondInteger;
    public int myThirdInteger;

    public float myFirstFloat = 10.5f;
    public float mySecondFloat = 2665.5f;

    public string myFirstText = "Mein erster Text!";

    public bool myFirstBool;

    public GameObject myGameObject;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Das ist meine erste Float Variable " + myFirstFloat);
        Debug.Log("Das ist meine zweite Float Variable " + mySecondFloat);

        Debug.Log("Das hier schreibe ich: " + myFirstText);
        
        Debug.Log("Das ist meine Bool " + myFirstBool);

        Debug.Log(myFirstText + " " + myFirstFloat + " " + mySecondInteger);
        Debug.Log(myFirstText + myFirstFloat + mySecondInteger);


        // Kann vorab festgelegt werden, muss aber nicht. Falls kein Wert vorgegeben: Zahlen in Unity werden addiert.
        // myFirstInteger = 10;
        // mySecondInteger = 20;

        myThirdInteger = myFirstInteger + mySecondInteger;

        Debug.Log(myThirdInteger);

        myThirdInteger += 10;

        Debug.Log(" Neu Neu Neu " + myThirdInteger);

    }

    // Update is called once per frame
    void Update()
    {
       
        

    }
}
