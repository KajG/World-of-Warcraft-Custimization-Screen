using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {

	public Color yourcolor;
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
		
	public void OnClick(){
		therealdeal.GetComponent<Renderer>().material.color = yourcolor;
		Hairstylecontroller.SpawnHair ();
	}

}
