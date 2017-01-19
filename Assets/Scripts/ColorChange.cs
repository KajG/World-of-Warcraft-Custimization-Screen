using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public Color red;
	public Color blue;
	public Color blonde;
	public Color cyan;
	public Color brown;
	public Color purple;
	public Color pink;
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
		case 2:
			therealdeal.GetComponent<Renderer> ().material.color = blonde;
			SpawnHair ();
			break;
		case 3:
			therealdeal.GetComponent<Renderer> ().material.color = cyan;
			SpawnHair ();
			break;
		case 4:
			therealdeal.GetComponent<Renderer> ().material.color = brown;
			SpawnHair ();
			break;
		case 5:
			therealdeal.GetComponent<Renderer> ().material.color = purple;
			SpawnHair ();
			break;
		case 6:
			therealdeal.GetComponent<Renderer> ().material.color = pink;
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
