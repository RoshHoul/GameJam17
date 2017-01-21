using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinCollection : MonoBehaviour {
    public GameObject coin;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {   
            if (Input.GetKey(KeyCode.Mouse1)) {
                Debug.Log("keydown");
                Destroy(coin);
                other.GetComponent<PlayerMovement>().holdCoin = true;

            }

        }
    } 
}
