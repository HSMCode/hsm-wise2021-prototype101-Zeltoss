using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{


    public float speed;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

      // if (Input.GetKeyDown(KeyCode.Space))
        {
           
           // Für normales 1 Step Bewegen
            // transform.Translate(Vector3.right);

        //    transform.Translate(Vector3.right * Time.deltaTime * speed);

        }


        //if (Input.GetKey(KeyCode.Space))
        {

           // transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
        
        if (Input.GetKey(KeyCode.D))
        {

           transform.Translate(Vector3.right * Time.deltaTime * speed);

        }
     
    }
}
