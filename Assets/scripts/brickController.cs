using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brickController : MonoBehaviour {

    public Manager manager;
	// Use this for initialization
	void Start () {
        manager = GameObject.FindWithTag("Manager").GetComponent<Manager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Ball")
        {
            manager.incScore();
            Destroy(gameObject);
        }
    }
}
