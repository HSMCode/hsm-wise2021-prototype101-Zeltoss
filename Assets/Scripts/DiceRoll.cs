using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{

    private string winMessage = "GEWONNEN! Deine Nummer lautet: ";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Lucky Number Zahlen: 6, 13 und 17. Drücke Space um zu würfeln. Viel Glück!");
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int diceRoll = Random.Range(1,21);

            if (diceRoll == 6 || diceRoll == 13 || diceRoll == 17)
            {
                Debug.Log(winMessage + diceRoll);
            }
            else
            {
                Debug.Log("VERLOREN! Deine Nummer lautet: " + diceRoll);
            }
        }

    }
}
