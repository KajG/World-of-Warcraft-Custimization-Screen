using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour {
	public List<GameObject> _childs = new List<GameObject>();
	public List<GameObject> _childs2 = new List<GameObject>();
	public GameObject buttonHairstyle;
	public GameObject buttonSkincolor;

	void Start () {
		for(int i = 0; i <_childs.Count; i++){
			_childs [i].SetActive (false);
			_childs2 [i].SetActive (false);
		}
	}
	public void OnClickActivate(){
		for (int i = 0; i < _childs.Count; i++) {
			_childs [i].SetActive (true);
			buttonHairstyle.SetActive (false);	
			buttonSkincolor.SetActive (false);		
		}
	}
	public void OnClickActivate2(){
		for (int i = 0; i < _childs.Count; i++) {
			_childs2 [i].SetActive (true);
			buttonHairstyle.SetActive (false);	
			buttonSkincolor.SetActive (false);		
		}
	}
	public void OnCLickGoBack(){
		for(int i = 0; i <_childs.Count; i++){
			_childs [i].SetActive (false);
			_childs2 [i].SetActive (false);
			buttonHairstyle.SetActive (true);		
			buttonSkincolor.SetActive (true);		
		}
	}
}
