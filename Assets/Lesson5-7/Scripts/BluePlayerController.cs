using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.forward * Time.deltaTime * speed); // двигаем вперед 
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(transform.forward * Time.deltaTime * -1 * speed); // двигаем назад
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(transform.right * Time.deltaTime * -1 * speed); // двигаем налево
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(transform.right * Time.deltaTime * speed); // двигаем направо 
        }
    }
}
