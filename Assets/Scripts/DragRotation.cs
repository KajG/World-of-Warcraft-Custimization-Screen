using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragRotation : MonoBehaviour {

	public Rigidbody character;
	public Vector3 mouseInput;
	Quaternion rotation;
	[SerializeField]
	private int speed;
	private float velocity;
	private float mousePosX;
	private bool clickLeft;
	private bool clickRight;

	void Start () {
		character = character.GetComponent<Rigidbody> ();
	}

	void Update () {
		rotation = this.transform.rotation;
		mouseInput = Input.mousePosition;
		mousePosX = mouseInput.x;
		//velocity += Time.deltaTime * speed;
		if (Input.GetKey (KeyCode.J)) {
			velocity += Time.deltaTime * speed;
			character.transform.localRotation = Quaternion.Euler (character.transform.position.x, velocity, character.transform.position.z);
		}
		if (Input.GetKey (KeyCode.K)) {
			velocity -= Time.deltaTime * speed;
			character.transform.localRotation = Quaternion.Euler (character.transform.position.x, velocity, character.transform.position.z);
		}
		if (Input.GetMouseButton (0)) {
			DragRotator ();
		}
	}
	void DragRotator(){
		if (!clickLeft && !clickRight) {
			character.transform.localRotation = Quaternion.Euler (0, mousePosX, 0);
			velocity = mousePosX;
		}
	}
}
