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
		counter2 += Time.deltaTime;
		if (for1on == true) {
			for (int i = 0; i < 5; i++) {

                counter += Time.deltaTime;
                if (counter >= 0.3f) {
                    Debug.Log("first 4");
					lights [i].SetActive (true);
//					i++;
					counter = 0;
				}

			}
		} /*
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
		} */
	}
    
    void OnCollisionEnter2D(Collision2D other)
    {

    } 
}

