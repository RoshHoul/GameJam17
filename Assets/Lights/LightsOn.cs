using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour {

	public GameObject[] lights;
	public int lightnum = 0;
	public int lightnum2 = 4;
	public float counter;
	public float counter2;
	public bool for1on = true;
	public bool for2on = false;
	// Use this for initialization
	void Start()
	{
		//InvokeRepeating ("lightsareon", 1f,0.5f);
	}

	void lightsareon()
	{

	}
	// Update is called once per frame
	void Update()
	{
		counter += Time.deltaTime;
		counter2 += Time.deltaTime;
		if (for1on == true) {
			for (int i = 0; i <= 4; i++) {

				if (counter >= 0.05f) {

					lights [lightnum].SetActive (true);
					lightnum++;
					counter = 0;
				}
				if (lightnum == 5) {
					lightnum = 6;
				}
				if (lightnum == 6) {
					lightnum = 6;
					for2on = true;
					for1on = false;
				}

			}




		}
		if (for2on == true) {
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

		}
	} 
}

