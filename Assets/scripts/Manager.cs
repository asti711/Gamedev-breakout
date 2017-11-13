using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    int score = 0;
    public Text scoreText;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void incScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
