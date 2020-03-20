using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_R_hit : MonoBehaviour {

	// Use this for initialization
	public GameObject SomeGameObject;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.R))
		{
			SomeGameObject.GetComponent<Rigidbody>().AddForce(transform.forward * 200, ForceMode.Force);
			SomeGameObject.GetComponent<Rigidbody>().useGravity = true;
		}
	}
	
}
