using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<Animator>().SetBool("Change", true);
        }
        else if (Input.GetMouseButtonDown(1))
        {
            GetComponent<Animator>().SetBool("Change", false);
        }

    }
}
