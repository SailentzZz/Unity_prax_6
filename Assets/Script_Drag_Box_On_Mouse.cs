using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script_Drag_Box_On_Mouse : MonoBehaviour {

	// Use this for initialization
	private Vector3 MouseOffSet;
	private float MouseZCoord;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnMouseDown()
	{
		MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
		MouseOffSet = gameObject.transform.position = GetMousePosition();
	}

	private Vector3 GetMousePosition()
	{
		Vector3 mousePoint = Input.mousePosition;
		mousePoint.z = MouseZCoord;
		return Camera.main.ScreenToWorldPoint(mousePoint);
	}

	private void OnMouseDrag()
	{
		transform.position = GetMousePosition() + MouseOffSet;
	}
}
