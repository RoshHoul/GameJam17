using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTrap : MonoBehaviour {
	public Animator PlayerAnims;
	public GameObject EndScreen;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Player") 
		{
			col.GetComponent<PlayerMovement> ().enabled = false;
			PlayerAnims.SetInteger ("States", 5);
			EndScreen.SetActive (true);
			col.GetComponentInChildren<Coin> ().enabled = false;
			col.GetComponentInChildren<CoinLeft>().enabled = false;
		}
	}
}
