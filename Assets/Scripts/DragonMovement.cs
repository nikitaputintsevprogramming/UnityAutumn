using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    { 
        transform.position = new Vector2(3,2);
    }

    // Update is called once per frame
    void Update()
    {
        /* for ( float i = 1.5f; i <= 2.0f; i = i + 0.1f)
         {
             transform.position = new Vector2(3,i);

         }
         for ( float i = 2.0f; i <= 1.5f; i = i - 0.1f)
         {
             transform.position = new Vector2(3,i);
         }*/
        
    }   
}