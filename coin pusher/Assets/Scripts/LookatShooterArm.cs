using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookatShooterArm : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Ray mouseray = Camera.main.ScreenPointToRay(Input.mousePosition);
        float midpoint = (transform.position - Camera.main.transform.position).magnitude * 0.5f;


        transform.LookAt(mouseray.origin + mouseray.direction * midpoint);
	}
}
