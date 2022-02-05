using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public float speed;

    void Update()
    {
      // if (Input.GetKeyDown(KeyCode.Space))
       // {
          // Für normales 1 Step Bewegen
          // transform.Translate(Vector3.right);
          // transform.Translate(Vector3.right * Time.deltaTime * speed);
       // }

        // after pressing the "d" key, the Player moves to the right
        if (Input.GetKey(KeyCode.D))
        {
           transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
    }
}
