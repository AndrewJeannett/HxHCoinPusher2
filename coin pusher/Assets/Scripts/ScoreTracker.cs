using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {
    public static float score ;
    public Text countText;

    // Use this for initialization
    void Start () {
        score = 100;
    }
	
	// Update is called once per frame
	void Update () {
        
            countText.text = "$" + ScoreTracker.score;
        
        
	}
}
