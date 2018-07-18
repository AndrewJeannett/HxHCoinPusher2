using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {

	public Transform shooterArm;

	private Transform pointer;
	
	// Update is called once per frame
	void Update () {
		float x = Input.GetAxis("Mouse X");
		float y = Input.GetAxis("Mouse Y");
		float z = Input.GetAxis("Mouse Z");
		pointer.localPosition = new Vector3(x, y, z);
		shooterArm.LookAt(pointer);
	}
}
