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
		Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		mousePositionVector3 = Camera.main.WorldToScreenPoint(mousePositionVector3) / 50f;
		Vector3 targetDirection = mousePositionVector3 - transform.position;
		shooterArm.rotation = Quaternion.LookRotation(Vector3.up, -targetDirection);
	}
}
