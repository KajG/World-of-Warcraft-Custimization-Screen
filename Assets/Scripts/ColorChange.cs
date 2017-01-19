using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public Color red;
	public Color blue;
	private Renderer hairColor;
	public HairstyleController Hairstylecontroller;
	private int posList;
	private GameObject therealdeal;

	void Start(){
		Hairstylecontroller = Hairstylecontroller.GetComponent<HairstyleController> ();
	}

	void Update(){
		posList = Hairstylecontroller.currentPosList;
		therealdeal = Hairstylecontroller.hairstyles[posList];
		hairColor = therealdeal.GetComponent<Renderer> ();
	}
		
	public void OnClick(int number){
		switch (number) {
		case 0:
			therealdeal.GetComponent<Renderer> ().material.color = red;
			SpawnHair ();
			break;
		case 1:
			therealdeal.GetComponent<Renderer> ().material.color = blue;
			SpawnHair ();
			break;
		default:
			break;
		}
	}

	void SpawnHair(){
		Hairstylecontroller.SpawnHair ();
	}
}
