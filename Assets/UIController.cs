using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour {

	public List<GameObject> buttons = new List<GameObject>();
	private List<Vector3> positions = new List<Vector3> ();
	private float planePos;
	private float scrollbarValue;
	public int speed = 40;
	public Scrollbar scrollbar;
	private Vector3 position;

	void Start () {
		for(int i = 0; i < buttons.Count; i++){
		positions.Add (buttons [i].transform.position);
		}
		scrollbar.value = 0.5f;
	}

	void Update () {
		scrollbarValue = scrollbar.value - 0.5f;
		for (int i = 0; i < buttons.Count; i++) {
			planePos = (scrollbarValue * speed) + positions[i].y;
			positions [i] = new Vector3 (positions [i].x, planePos, positions [i].z);
			buttons [i].transform.position = positions [i];
		}
	}
	public void OnRelease(){
		scrollbar.value = 0.5f;
	}
}
