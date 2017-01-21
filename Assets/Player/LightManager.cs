using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour {

	public GameObject curLight;
	public GameObject lights;
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

	}
}
