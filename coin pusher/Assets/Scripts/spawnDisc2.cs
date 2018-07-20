using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class spawnDisc2 : MonoBehaviour {
    public Rigidbody discPrefab;
    public Transform Shooter;
    public int discCounter;
    public Text discCountText;
    public Transform discObject;
    

    // Use this for initialization
    void Start () {
        discCounter = 1000;
        
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1") & (ScoreTracker.score > 0))
        {
            Rigidbody clone;
            clone = Instantiate(discPrefab, Shooter.position, Shooter.rotation,discObject );
            ScoreTracker.score -= .25f;
            clone.GetComponent<Rigidbody>().AddForce(transform.up * 8000);
        }
      
    }

 
}
