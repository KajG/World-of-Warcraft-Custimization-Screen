using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DragRotation : MonoBehaviour {

	public Rigidbody character;
	public Vector3 mouseInput;
	Quaternion rotation;
	[SerializeField]
	private float speed;
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
		speed += Time.deltaTime *speed;
		character.transform.localRotation = Quaternion.Euler (character.transform.position.x, speed, character.transform.position.z);
		//print (rotation.y);
		//print (speed);
		/*if (clickRight) {
			//character.transform.localRotation = Quaternion.Euler (0, mousePosX - speed, 0);
			rotation.y += speed;
			this.transform.rotation = rotation;
		}
		if (clickLeft) {
			//character.transform.localRotation = Quaternion.Euler (0, speed, 0);
			rotation.y -= speed;
			this.transform.rotation = rotation;
		}*/
		if (Input.GetMouseButton (0)) {
			DragRotator ();
		}
	}
	void DragRotator(){
		character.transform.localRotation = Quaternion.Euler (0, mousePosX, 0);
	}
	public void OnClickLeft(){
		clickLeft = true;
	}
	public void OnClickRight(){
		clickRight = true;
	}
}
