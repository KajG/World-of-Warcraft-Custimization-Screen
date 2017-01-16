using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterRotationInv : MonoBehaviour {

	public DragRotation Dragrotation;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.GetComponent<Rigidbody>().transform.localRotation = Quaternion.Euler (this.GetComponent<Rigidbody>().transform.position.x, Dragrotation.velocity, this.GetComponent<Rigidbody>().transform.position.z);
	}
}
