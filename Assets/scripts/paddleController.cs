using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddleController : MonoBehaviour
{

    public Rigidbody rigidBody;
    public float speed;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        if (x < 0)
        {
            MoveLeft();
        }
        if (x > 0)
        {
            MoveRight();
        }
        if (x == 0)
        {
            Stop();
        }
        Vector3 position = transform.position;

        position.x = Mathf.Clamp(position.x, -10, 10);
        transform.position = position;

    }

    void MoveLeft()
    {
        rigidBody.velocity = new Vector3(-speed, 0);
    }

    void MoveRight()
    {
        rigidBody.velocity = new Vector3(speed, 0);
    }

    void Stop()
    {
        rigidBody.velocity = Vector3.zero;
    }
}
