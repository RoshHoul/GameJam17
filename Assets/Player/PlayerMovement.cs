using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D rb;
    private bool onFloor;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        var val = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(speed * val, rb.velocity.y);

        if (Input.GetKey(KeyCode.Space))
        {   
            if (onFloor) 
                rb.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }
        
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == "Platform")
        {
            onFloor = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Platform")
            onFloor = true;
        if (other.gameObject.tag == "Jumper")
        {
            rb.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }
    }
}
