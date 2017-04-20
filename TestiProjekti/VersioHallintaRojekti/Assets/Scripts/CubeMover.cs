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

        transform.position += new Vector3(1, 2, 3) * Time.deltaTime * speed;
		
	}
}
