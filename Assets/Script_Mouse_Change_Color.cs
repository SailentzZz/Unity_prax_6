using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Mouse_Change_Color : MonoBehaviour {

	// Use this for initialization
	private Renderer RendererProp;
	void Start ()
	{
		RendererProp = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseEnter()
	{
		RendererProp.material.color = Color.green;
	}

	private void OnMouseExit()
	{
		RendererProp.material.color = Color.blue;
	}
}
