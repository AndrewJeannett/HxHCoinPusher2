using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundFric : MonoBehaviour {


    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "coin")
        {


            col.transform.parent = gameObject.transform;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "coin")
        {
            col.transform.parent = null;
        }
    }
}

 
