using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public bool holdCoin = true;
    public float speed = 5f;
    private Rigidbody2D rb;
    public bool onFloor;
    public Animator CharacterAnims; 
    private float distance;
    public GameObject coin;
    public float jumpStrength;
    private bool isIdle = true;
    public static Vector3 lastPosition;


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
        if (Input.GetKey(KeyCode.D) && onFloor == true)
        {
            CharacterAnims.SetInteger("States", 1);
            isIdle = false;
        }
        else if (Input.GetKey(KeyCode.A) && onFloor == true)
        {
            CharacterAnims.SetInteger("States", 1);
            isIdle = false;
        }
        else if (onFloor == false)
        {
            CharacterAnims.SetInteger("States", 3);
            isIdle = false;
        }
        else
        {
            CharacterAnims.SetInteger("States", 0);
            isIdle = true;
        }
        if (Input.GetKey(KeyCode.Mouse0) && holdCoin && isIdle == false)
        {
            CharacterAnims.SetInteger("States", 2);
        }
        else if (Input.GetKey(KeyCode.Mouse0) && holdCoin && isIdle == true)
        {
            CharacterAnims.SetInteger("States", 4);
        }


        if (Input.GetKey(KeyCode.Space))
        {   
            if (onFloor) 
                rb.AddForce(new Vector2(0, jumpStrength), ForceMode2D.Impulse);
            CharacterAnims.SetInteger("States", 3);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Position saved");
            lastPosition = gameObject.transform.position;
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
			Debug.Log ("Jumper Hit");
		//	gameObject.transform.Translate (-12, 14, 0);
            rb.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
        }


    }
}
