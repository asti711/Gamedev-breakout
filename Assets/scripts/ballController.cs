using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float ballForce;
	// Use this for initialization
	void Start () {
        rigidBody.AddForce(new Vector2 (ballForce, ballForce));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
