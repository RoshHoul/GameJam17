using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public bool holdCoin = true;
    public float speed = 5f;
    private Rigidbody2D rb;
    private bool onFloor;
    public Animator CharacterAnims;
    private float distance;
    public GameObject coin;
    public float jumpStrength;

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
        if (val < 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (val > 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        if (Input.GetKey(KeyCode.D))
        {
            CharacterAnims.SetInteger("States", 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            CharacterAnims.SetInteger("States", 1);
        }
        else
        {
            CharacterAnims.SetInteger("States", 0);
        }
        if (Input.GetKey(KeyCode.Mouse0) && holdCoin)
        {
            CharacterAnims.SetInteger("States", 2);
        }

        distance = Vector3.Distance(transform.position, coin.transform.position);
        Debug.Log(distance);
        if (distance < 10f)
        {
            Debug.Log("MONEY");
        }

        if (Input.GetKey(KeyCode.Space))
        {   
            if (onFloor) 
                rb.AddForce(new Vector2(0, jumpStrength), ForceMode2D.Impulse);
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
