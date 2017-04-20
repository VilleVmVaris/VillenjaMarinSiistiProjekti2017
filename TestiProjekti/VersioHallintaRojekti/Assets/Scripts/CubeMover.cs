using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour {

    public float speed = 19;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.Space))
        {

            transform.position += new Vector3(1, 2, 3) * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.Backspace))
        {
            transform.position -= new Vector3(1, 2, 3) * Time.deltaTime * speed;
        }

        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 1, 0);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
