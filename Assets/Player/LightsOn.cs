using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour {

	public GameObject[] lights;
	private GameObject me;
	public int lightnum = 0;
	public int countlights = 0;
	public float counter;
	public float counter2;
	public float timing;
	public bool for2on = false;
	Vector3 Zaxispos;
	public GameObject coin;
	// Use this for initialization
	void Awake()
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y, -10f);
	}
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{

		counter += Time.deltaTime;
		counter2 += Time.deltaTime;
		if (for2on == true) 
		{
			timing += Time.deltaTime;
		}
		if (this.tag == "ClonedLights" || coin.GetComponent<LightManager> ().lightsdone == true || coin.GetComponent<LightManager> ().lightcount != 4) 
		{
			clonelights ();
		}


		/*if (for2on == true) {
			for (int j = 4; j >= 0; j--) {
				if (counter2 >= 3f) {

					lights [lightnum2].SetActive (false);
					if (lightnum2 == 0) {
						lightnum2 = 0;
						for2on = false;
					}
					lightnum2--;
					counter = 0;
				}
			}
		} */
	}

	void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject.tag == "Platform") 
		{
			InvokeRepeating ("coinlights", 0f, 0.01f);
		}

	} 
	void clonelights()
	{
		InvokeRepeating("coinlights", 0f,1f);
	}
	void coinlights()
	{
		Debug.Log ("true");
		if (counter >= 0.01f) 
			{
				Debug.Log ("counter");
				lights [lightnum].SetActive (true);
				counter = 0;
				lightnum++;
				countlights++;
			}
		if (lightnum >= 4) 
			{
				lightnum = 4;
				for2on = true;
			}
		if (countlights >= 4) 
		{
			countlights = 4;
		}
		if (countlights != 0 && timing >= 1f) 
			{
			Debug.Log ("counter");
			lights [lightnum].SetActive (false);
			counter2 = 0;
			lightnum--;
			}
			if (lightnum <= 0) 
			{
				coin = GameObject.FindGameObjectWithTag ("Coin");
				coin.GetComponent<LightManager> ().lightsdone = true;
				if(coin.GetComponent<LightManager> ().lightcount == 4 || coin.GetComponent<LightManager> ().counter == 4)
					{
						coin.GetComponent<LightManager> ().lightsdone = false;
					}
				coin.GetComponent<LightManager> ().lightcount += 1;
				Destroy (this.gameObject);
				lightnum = 0;
			}




	}
}

