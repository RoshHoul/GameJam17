using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAim : MonoBehaviour {

    void Start()
    {

    }

    void Update()
    {
        Vector3 mouse = Input.mousePosition;
        mouse.z = +10;
//        mouse = mouse * 10f;
        transform.position = Camera.main.ScreenToWorldPoint(mouse);
    }
}
