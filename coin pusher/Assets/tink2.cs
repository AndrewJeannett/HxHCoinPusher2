using UnityEngine;
using System.Collections;

public class tink2 : MonoBehaviour

{



    void OnCollisionEnter(Collision col)
    {
        AudioSource audio = GetComponent<AudioSource>();


        if (col.gameObject.name == "disc(Clone)")

        {

            audio.Play();
            Debug.Log("dink");


        }
    }
}
