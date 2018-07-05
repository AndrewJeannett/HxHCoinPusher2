using UnityEngine;
using System.Collections;

public class tink : MonoBehaviour
    
{



    void OnCollisionEnter(Collision col)
    {
        AudioSource audio = GetComponent<AudioSource>();


        if (col.gameObject.name == "pachinko")

        {

            audio.Play();
            Debug.Log ("tink");


        }
        if (col.gameObject.name == "sensor")
        {
            Debug.Log("score");
        }
    }
}
