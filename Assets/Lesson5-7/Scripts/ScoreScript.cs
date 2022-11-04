using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public Transform ball;
    public Text Score;
    int score = 0;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "ball")
        {         
            score++;
            Score.text = score.ToString();

            ball.position = Vector3.zero;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
