using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputTest : MonoBehaviour
{
    public int numberOne = 1;
    public int numberTwo = 20;
    public int numberThree = 0;

    // checking how often you pressed the space key. After every pressed key, another If-Statement gets triggered.
    void Update()
    {
       
            if (Input.GetKeyDown(KeyCode.Space))
            {
                // Debug.Log("space key was pressed.");

                // numberOne = numberOne * numberTwo;
                // Debug.Log(numberOne);

                numberThree++;
                Debug.Log(numberThree);
            }


            if(numberThree ==1)
            {
                //when true do this
                Debug.Log("The if-statement was true: 1");
            }
            else if(numberThree == 2) 
            {
                //when true do this
                Debug.Log("The if-statement was true: 2");
            }
            else if (numberThree == 3)
            {
                //when true do this
                Debug.Log("The if-statement was true: 3");
            }
           else
            {
                // do this
                Debug.Log("The if-statement was false.");
            }
       
    }
}
