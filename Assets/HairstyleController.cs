using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class HairstyleController : MonoBehaviour {
	[SerializeField]
	private List<GameObject> hairstyles = new List<GameObject>();
	public BoxCollider headCollider;
	public BoxCollider handCollider;
	private int currentPosList;
	public GameObject hairstyleInst;
	private GameObject curHair;


	void Start () {
		curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
		curHair.transform.parent = headCollider.transform;
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			SpawnHair ();
			currentPosList += 1;
		}
		if (currentPosList >= hairstyles.Count) {
			currentPosList = 0;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			SpawnHair ();
			currentPosList -= 1;
			if (currentPosList < 0) {
				currentPosList = hairstyles.Count - 1;
			}
		}
	}
	public void OnClick(int position){
		print (position);
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
	void SpawnHair(){
		Destroy (curHair);
		curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
		curHair.transform.parent = headCollider.transform;
	}
}
