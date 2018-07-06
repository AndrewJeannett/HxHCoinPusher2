using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zero : MonoBehaviour {
    public float[] reelPos;
    private float numPos;
	// Use this for initialization
	void Start () {

       
    }

    // Update is called once per frame
    void Update () {
        
        if (Input.GetButtonDown("Jump"))
        {
            int index1 = Random.Range(0, reelPos.Length);
            numPos = reelPos[index1];
            Debug.Log(index1);
        }
            transform.eulerAngles= new Vector3(numPos, 180, 0);
       
    }
    
}
