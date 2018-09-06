using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardColor : MonoBehaviour {
   public float alpha;
    // Use this for initialization

  IEnumerator Fade()
    {
        Image image = GetComponent<Image>();
        var tempColor = image.color; 
        image.color = tempColor;
        
        for (int i = 0; i < 20; i++)
        {
            Debug.Log(i);
            alpha += .05f;
            tempColor.a += alpha;

            new WaitForSeconds(.1f);
        }

        yield return null;
    }
    // Update is called once per frame
    void Update ()
    {

        if (Input.GetKeyDown("f"))
        {
            
                StartCoroutine("Fade");
               
            
        }

       
    }

  
}
