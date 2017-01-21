using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour {

	public GameObject curLight;
	public GameObject lights;
	public GameObject lightsingame;
	public GameObject gl;
	public bool lig;
	public bool once;
	public bool lightsdone = false;
	public float counter;
	public float lighttiming;
	public float lightcount;
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (lightsdone == true) 
		{
			GameObject curLight =  Instantiate(lights, transform.position, Quaternion.identity) as GameObject;
			curLight.transform.parent = this.transform;
			counter++;
			lightsdone = false;
		}
		if (counter == 4) 
		{
			lightsdone = false;
		}
		if (lightcount >= 4) 
		{
			lightcount = 4;
			lightsdone = false;
		}
		if (lightsdone == false) 
		{
			
		}
		if (lig == true) 
		{
			lightsingame = GameObject.FindGameObjectWithTag("ClonedLight");
			lightsingame.GetComponent<LightsOn> ().lightswitch = true;
			lig = false;
		}

	}
	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == "Platform" && !once) 
		{
			once = true;
			Debug.Log ("suka");
			gl =  Instantiate(lights, transform.position, Quaternion.identity) as GameObject;
			gl.transform.parent = this.transform;
			lig = true;
		}

	}
	void OnCollisionExit2D(Collision2D other2)
	{
		if (other2.gameObject.tag == "Platform" && once) 
		{
			once = false;
		}
	}
}
