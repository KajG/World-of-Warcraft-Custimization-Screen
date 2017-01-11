using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public List<Camera> cameras = new List<Camera> ();



	void Start () {
		cameras [1].enabled = true;
	}
	
	void Update () {
		/*
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			cameras [1].enabled = true;
			cameras [0].enabled = false;
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			cameras [1].enabled = false;
			cameras [0].enabled = true;
		}
		*/
	}
}
