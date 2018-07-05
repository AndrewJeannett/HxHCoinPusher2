using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class casinosound : MonoBehaviour {
    public AudioClip[] spinSound;
    public AudioSource spinSource;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        int index = Random.Range(0, spinSound.Length);
        spinSource.clip = spinSound[index];
        
       spinSource.Play();
	}
}
