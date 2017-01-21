using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsOn : MonoBehaviour {

    public GameObject[] lights;
    public int lightnum = 0;
    public float counter;
    public float counter2;
    public bool count1;
    public bool count2;
    public bool forstop = true;
    public bool for2stop = false;
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
/*        for (int i = 0; i <= 5; i++) {
            Debug.Log("this is the" + i + " time");
            counter += Time.deltaTime;
            if (counter >= 0.3f) {

                lights[i].SetActive(true);
                counter = 0;
            }




        }
        for (int j = 5; j >= 5; j--) {

            counter2 = counter2 + Time.deltaTime;
            if (counter2 >= 2f) {
                lights[j].SetActive(false);
                counter2 = 0;
                //					forstop = false;
            }
        } */
    } 

}
