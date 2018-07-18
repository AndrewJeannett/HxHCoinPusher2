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
		// Get position of mouse and orient it from world space to screen space
		Vector3 mousePositionVector3 = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
		mousePositionVector3 = Camera.main.WorldToScreenPoint(mousePositionVector3) / 50f;
		// Restrict movement of shooter arm
		mousePositionVector3.x = Mathf.Clamp(mousePositionVector3.x, 0, Screen.width - 10);
		// Produce target direction from mouse pos and rotate shooter arm toward that target 
		Vector3 targetDirection = mousePositionVector3 - transform.position;
		shooterArm.rotation = Quaternion.LookRotation(Vector3.up, -targetDirection);
	}
}
