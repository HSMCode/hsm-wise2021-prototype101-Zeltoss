using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRoll : MonoBehaviour
{
    // Message if you win
    private string winMessage = "GEWONNEN! Deine Nummer lautet: ";

    // Prints the Description in the console
    void Start()
    {
        Debug.Log("Lucky Number Zahlen: 6, 13 und 17. Drücke Space um zu würfeln. Viel Glück!");
    }

    // After hitting the space key the dice will roll
    // if: When the result is 6, 13 or 17 you win and get the win message printed
    // else: Any other number let you lose and the lose-message will be printed
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
