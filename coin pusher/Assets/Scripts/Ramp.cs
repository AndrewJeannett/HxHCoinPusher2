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
        // Get position of mouse, restrict x movement, and orient it from world space to screen space
        Vector3 mousePositionVector3 = new Vector3(
            Mathf.Clamp(Input.mousePosition.x, 0, 15f), 0, 0);
        mousePositionVector3 = Camera.main.WorldToScreenPoint(mousePositionVector3) / 75f;
        // Produce target direction from mouse pos and rotate shooter arm toward that target 
        Vector3 targetDirection = mousePositionVector3 - transform.position;
        Quaternion rotation = Quaternion.LookRotation(Vector3.up, -targetDirection);
        shooterArm.rotation = Quaternion.Slerp(shooterArm.rotation, rotation, Time.deltaTime * 2);
    }
}
