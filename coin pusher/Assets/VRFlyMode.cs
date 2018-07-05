using UnityEngine;
using System.Collections;

public class VRFlyMode : MonoBehaviour
{

    // This script should be set in a GameObject parent of the camera
    // The relative position of the camera shoudl be 0 0 0 and no scale neither rotation (as a start direction)

    public GameObject cameraObj;
    public float speed = 0.5f; // in m/sec



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl))
            transform.position = transform.position += cameraObj.transform.forward * speed * Time.deltaTime;

    }
}
