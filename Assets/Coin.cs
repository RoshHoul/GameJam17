using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    public Transform myTarget;
    
    public GameObject coin;
    float shootAngle = 45f;
    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
 	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            GameObject curCoin = Instantiate(coin, transform.position, Quaternion.identity);
            rb = curCoin.GetComponent<Rigidbody2D>();
            rb.velocity = BallisticVel(myTarget, shootAngle);
            Destroy(curCoin, 3);
        }
	}

    Vector2 BallisticVel(Transform target, float angle)
    {
        var dir = target.position - transform.position;
        var h = dir.y;
        dir.y = 0;
        var dist = dir.magnitude;
        var a = angle * Mathf.Deg2Rad;
        dir.y = dist * Mathf.Tan(a);
        dist += h / Mathf.Tan(a);

        var vel = Mathf.Sqrt(dist * Physics.gravity.magnitude / Mathf.Sin(2 * a));
        return vel * dir.normalized;
    }

    
}
