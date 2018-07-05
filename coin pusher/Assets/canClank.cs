using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canClank : MonoBehaviour {
    public AudioSource clank;
	// Use this for initialization
	void Start () {
	
	}
    void OnCollisionEnter(Collision col) { 
    //void OnTriggerEnter(Collider col) { 
    


        if (col.gameObject.name == "disc(Clone)")

        {

            clank.Play();
            Debug.Log("clank");


        }
    }
// Update is called once per frame
void Update () {
		
	}
}
