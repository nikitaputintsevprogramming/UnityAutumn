using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenquinController : MonoBehaviour
{

    public float speed = 5.0f;
    public float jumpForce = 10.0f;

    new private Rigidbody2D rigidbody2D;
    private Animator animator;
    private SpriteRenderer sprite;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void Run()
    {
        animator.SetInteger("State", 1);
        Vector3 direction = transform.right * Input.GetAxis("Horizontal");
        transform.position = Vector3.MoveTowards(transform.position, transform.position + direction, speed * Time.deltaTime);
        sprite.flipX = direction.x < 0.0f;
    }

    private void Jump()
    {
        animator.SetInteger("State", 2);
        rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void FixedUpdate()
    {
        animator.SetInteger("State", 0);
        if(Input.GetButton("Horizontal"))
        {
            Run();
        }
        if(isGround() && Input.GetButton("Jump"))
        {
            Jump();
        }
    }

    private bool isGround()
    {
        bool ground = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.7f);
        foreach(Collider2D coll in colliders)
        {
            if(coll.gameObject.name == "Ground" && colliders.Length == 2)
            {
                ground = true;
            }
        }
        return ground;
    }
}
