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
	}
	
	void Update () {
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			Destroy (curHair);
			curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
			currentPosList += 1;
		}
		if (currentPosList >= hairstyles.Count) {
			currentPosList = 0;
		}
		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			Destroy (curHair);
			curHair = Instantiate (hairstyles [currentPosList], headCollider.center, Quaternion.identity) as GameObject;
			currentPosList -= 1;
			if (currentPosList < 0) {
				currentPosList = hairstyles.Count - 1;
			}
		}
	}
}
