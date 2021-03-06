﻿using System.Collections;
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
	[SerializeField]private GameObject _body;

	void Start(){
		Hairstylecontroller = Hairstylecontroller.GetComponent<HairstyleController> ();
	}

	void Update(){
		posList = Hairstylecontroller.currentPosList;
		therealdeal = Hairstylecontroller.hairstyles[posList];
		hairColor = therealdeal.GetComponentInChildren<Renderer> ();
	}
		
	public void OnClick(int number){
		switch (number) {
		case 0:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = red;
			SpawnHair ();
			break;
		case 1:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = blue;
			SpawnHair ();
			break;
		case 2:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = blonde;
			SpawnHair ();
			break;
		case 3:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = cyan;
			SpawnHair ();
			break;
		case 4:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = brown;
			SpawnHair ();
			break;
		case 5:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = purple;
			SpawnHair ();
			break;
		case 6:
			therealdeal.GetComponentInChildren<Renderer> ().material.color = pink;
			SpawnHair ();
			break;
		default:
			break;
		}
	}
	public void OnClickBody(int number){
		switch (number) {
		case 0:
			_body.GetComponent<Renderer> ().material.color = red;
			break;
		case 1:
			_body.GetComponent<Renderer> ().material.color = blue;
			break;
		case 2:
			_body.GetComponent<Renderer> ().material.color = blonde;
			break;
		case 3:
			_body.GetComponent<Renderer> ().material.color = cyan;
			break;
		case 4:
			_body.GetComponent<Renderer> ().material.color = brown;
			break;
		case 5:
			_body.GetComponent<Renderer> ().material.color = purple;
			break;
		case 6:
			_body.GetComponent<Renderer> ().material.color = pink;
			break;
		default:
			break;
		}
	}


	void SpawnHair(){
		Hairstylecontroller.SpawnHair ();
	}
}
