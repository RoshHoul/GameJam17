using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoints : MonoBehaviour {
    public GameObject player;
    public GameObject EndScreen;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void respawn()
    {
        player.SetActive(false);
        player.transform.position = PlayerMovement.lastPosition;
        player.GetComponent<PlayerMovement>().enabled = true;
        EndScreen.SetActive(false);
        player.SetActive(true);
    }
	public void quit()
	{
		Application.Quit ();
	}
        
}
