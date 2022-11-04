using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMoveScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(3, 1);
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;
    private new Rigidbody2D rigidbody;

    public int numberTime = 10;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(speed.x * direction.x * Time.deltaTime * numberTime,
           speed.y * direction.y * Time.deltaTime * numberTime);
    }

    void FixedUpdate()
    {
        rigidbody.velocity = movement;
    }
}
