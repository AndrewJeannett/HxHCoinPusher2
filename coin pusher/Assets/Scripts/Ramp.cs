using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {

	public Collider rampCollider;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse X") < 0) {
			Debug.Log("Mouse moved left");
		}
		if (Input.GetAxis("Mouse X") > 0) {
			Debug.Log("Mouse moved right");
		}
	}
}
