using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Change_Color : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerStay(Collider collider)
	{
		if (Input.GetKeyDown(KeyCode.T) && collider.GetType() == typeof(BoxCollider))
		{
			GetComponent<Renderer>().material.color = Color.red;
		}
	}
}
