using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Info_Out : MonoBehaviour {

	// Use this for initialization
	private bool flag = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Y))
		{
			flag = true;
		}

		if (Input.GetKeyUp(KeyCode.Y))
		{
			flag = false;
		}
	}

	private void OnMouseDown()
	{
		if (flag)
		{
			Debug.Log(name);
			Debug.Log(transform.position);
			Debug.Log(GetComponent<Renderer>().material.color);
			Debug.Log(GetComponent<Rigidbody>().mass);
		}
	}
}
