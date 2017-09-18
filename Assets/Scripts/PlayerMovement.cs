using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    Rigidbody2D myRigidBody;

	// Use this for initialization
	void Start () {
        //teleports game object to center
        //transform.position = new Vector3(0,0,0);

        myRigidBody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0.1f, 0, 0));
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-0.1f, 0, 0));
        }

        //float horizontalInput = Input.GetAxis("Horizontal");

        //transform.Translate(0.1f * horizontalInput, 0, 0);

        //Debug.Log("Horizontal Input: " + horizontalInput);

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 2f, 0));
        }

        

        //if (Input.GetKey(KeyCode.S))
        //{
        //    transform.Translate(new Vector3(0, -0.1f, 0));
        //}

    }
}

