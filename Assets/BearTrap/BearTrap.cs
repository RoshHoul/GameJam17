using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearTrap : MonoBehaviour {
	public Animator Snap;
	public GameObject Player;
	public GameObject EndScreen;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OnTriggerEnter2D(Collider2D col)
	{
		if (GameObject.FindGameObjectWithTag("Player"))
		{
			Snap.SetInteger ("States", 1);
			Player.GetComponent<PlayerMovement> ().enabled = false;
			EndScreen.SetActive (true);
		}
				
	}
}
