using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramp : MonoBehaviour {

	Transform shooterArm;

	void Start () {
		shooterArm = GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update () {
		shooterArm.rotation = Quaternion.LookRotation(Input.mousePosition, Vector3.up);
	}
}
