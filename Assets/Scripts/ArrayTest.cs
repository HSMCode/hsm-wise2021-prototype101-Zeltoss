using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTest : MonoBehaviour
{

    public int dice = 0;
    public int luckyNumber1 = 6;
    public int luckyNumber2 = 12;
    public int luckyNumber3 = 18;

// Um einfach nur 3 Shelfs zu bauen.
// public int[] luckyNumberArray = new int [3];
 

// Um direkt Zahlen in die Shelfs zu packen.
 public int[] luckyNumberArray = {6,12,18};

    // Start is called before the first frame update
    void Start()
    {
        luckyNumberArray[0] = 6;
        luckyNumberArray[1] = 12;
        luckyNumberArray[2] = 18;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
