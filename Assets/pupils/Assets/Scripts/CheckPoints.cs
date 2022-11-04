using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoints : MonoBehaviour
{
    public Transform Player;

    private Vector3 StartPos = Vector3.zero;

    public Transform CheckPointRed;
    public bool CheckRed = false;

    public Transform CheckPointGreen;
    public bool CheckGreen = false;


    // Start is called before the first frame update
    void Start()
    {
        StartPos = Player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "DeathGroundYellow")
        {
            if(CheckRed)
            {
                gameObject.transform.position = CheckPointRed.position;
            }
            else if(CheckGreen)
            {
                gameObject.transform.position = CheckPointGreen.position;
            }
            else
            {
                gameObject.transform.position = StartPos;
            }            
        }       
    }

    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.name == "CheckpointRed")
        {            
            print("Red Check is save");
            CheckRed = true;
            CheckGreen = false;
        }
        else if (collision.gameObject.name == "CheckpointGreen")
        {            
            print("Green Check is save");
            CheckGreen = true;
            CheckRed = false;
        }
    }

}
