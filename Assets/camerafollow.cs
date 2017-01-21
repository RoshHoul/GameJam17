using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
    public GameObject player;
    public Vector3 offset;

    public float xMax;
    public float xMin;
    public float yMax;
    public float yMin;

    void Update()
    {
       /* if (transform.position.x >= xMax)
        {
            offset.x = offset.x  - 0.2f;
        }
        if (transform.position.y < yMin)
        {
            offset.y = offset.y + 0.2f;
        }*/
        
        transform.position = new Vector3(player.transform.position.x + offset.x, player.transform.position.y + offset.y, offset.z);
            
        
        
      

        
      
    }
}
