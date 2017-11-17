using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class brickController : MonoBehaviour {

    public managerController manager;
	// Use this for initialization
	void Start () {
        manager = GameObject.FindWithTag("Manager").GetComponent<managerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Ball")
        {
            manager.incScore();
            Destroy(gameObject);
        }
    }
}
