using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {


    public float moveSpeed = 10;
    public float rotateSpeed = 15;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        // Getkeyup only activates once you release the key and it "goes up"
        // getkeydown is used to have a single input (once per frame) when the key "goes down"
        // input.getkey is one great for continuous pressing of the same key. You can hold down the key think Rapidfire

        if (Input.GetKey("a"))
        {
            //transform.Translate((Vector3.left) * moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.down * rotateSpeed);

        }
        if (Input.GetKey("d"))
        {
            //transform.Translate((Vector3.right)* moveSpeed * Time.deltaTime);
            transform.Rotate(Vector3.up * rotateSpeed);

        }
        if (Input.GetKey("w"))
        {
            transform.Translate((Vector3.forward) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetKey("s"))
        {
            transform.Translate((Vector3.back) * moveSpeed * Time.deltaTime);
        }

        if (Input.GetMouseButton(1))
        {
            moveSpeed = 30.0f;
        }

        if (!Input.GetMouseButton(1))
        {
            moveSpeed = 10.0f;
        }

	}   
}
