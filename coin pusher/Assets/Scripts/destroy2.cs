﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroy2 : MonoBehaviour { 
    
   

    
   

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "bottom")
        {
            ScoreTracker.score += 5;
            DestroyObject(gameObject);
            


        }
    }
}


