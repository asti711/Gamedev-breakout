using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballController : MonoBehaviour {

    public Rigidbody2D rigidBody;
    public float ballForce;
    bool isPlaying = false;
    // Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Space) && isPlaying == false)
        {
            transform.SetParent(null);
            rigidBody.isKinematic = false;
            rigidBody.AddForce(new Vector2(ballForce, ballForce));
            isPlaying = true;

        }
	}


}
