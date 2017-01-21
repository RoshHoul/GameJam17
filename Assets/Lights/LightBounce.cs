using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBounce : MonoBehaviour {

	public GameObject gobject;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
	void OnCollisionEnter2D(Collision2D col)
	{
		Debug.Log ("beeee");
		if (col.gameObject.tag == "Rock") 
		{
			Debug.Log ("haha");
			gobject = col.gameObject;
			gobject.GetComponent<SpriteRenderer>().color = new Color (0,0,0,255);
			this.gameObject.GetComponent<CircleCollider2D> ().isTrigger = true;
		}
	}
}
