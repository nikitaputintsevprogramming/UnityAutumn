using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenguinHP : MonoBehaviour
{
    public int HP = 3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(HP < 1)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject);
            HP--;
            AudioSource audio = GetComponent<AudioSource>();
            audio.Play();
        }
    }
}
