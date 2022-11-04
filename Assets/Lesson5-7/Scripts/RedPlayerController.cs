using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPlayerController : MonoBehaviour
{
    public float speed = 3.0f;
    public Transform ball;
    public Transform gate;
    private Vector3 BallPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y <= 2)
        {
            BallPos = new Vector3(ball.position.x - 1, ball.position.y, ball.position.z);
            transform.position = Vector3.MoveTowards(transform.position, BallPos, Time.deltaTime * speed);
        }
    }
    private void OnCollisionStay(Collision collision)
    {
        if(collision.gameObject.name == "ball")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 200 * speed);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.forward * 250 * speed*-1);
            collision.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.right * 150 * Random.value);

            transform.position = Vector3.MoveTowards(transform.position, gate.position, Time.deltaTime * speed);
        }
    }

}
