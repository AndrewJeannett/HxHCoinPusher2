using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {
    
    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        
		
	}
    void FixedUpdate()
    {

        float rotspeed = Time.deltaTime* 1500;
        transform.Rotate(new Vector3(rotspeed, 0, 0));
        Debug.Log (rotspeed);
    }
    }
