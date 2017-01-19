using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HairstyleController : MonoBehaviour {
	[SerializeField]
	public List<GameObject> hairstyles = new List<GameObject>();
	public BoxCollider headCollider;
	public BoxCollider handCollider;
	public int currentPosList;
	public GameObject hairstyleInst;
	public GameObject curHair;
	private float headPosY;

	void Start () {
		curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
	}
	
	void Update () {
		curHair.transform.rotation = headCollider.transform.rotation;
		headPosY = headCollider.transform.localPosition.y;
		curHair.transform.position = new Vector3(headCollider.center.x, headCollider.center.y + headPosY, headCollider.center.z);
		print (headCollider.transform.localPosition.y);

		if (currentPosList >= 0) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				SpawnHair ();
				currentPosList += 1;
			}
			if (Input.GetKeyDown (KeyCode.DownArrow)) {
				SpawnHair ();
				currentPosList -= 1;
			}
		} else {
			currentPosList = 0;
		}
	}
	public void OnClick(int position){
		switch (position) {

		case 0:
			currentPosList = 0;
			SpawnHair ();
			break;
		case 1:
			currentPosList = 1;
			SpawnHair ();
			break;
		case 2:
			currentPosList = 2;
			SpawnHair ();
			break;
		
		default:
			break;
		}
	}
	public void SpawnHair(){
		Destroy (curHair);
		curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
	}
}
