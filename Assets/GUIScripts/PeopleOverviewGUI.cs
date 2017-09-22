﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PeopleOverviewGUI : MonoBehaviour {

	public GameObject PersonHolder;
	public GameObject PeopleViewHolder;
	public GameObject InternalHolder;
	public Canvas MainCanvas;

	public Button UpButton;
	public Button DownButton;
	public Button CloseButton;

	public static bool mouseDown;

	public bool Moving;
	public int Direction;

	private List<GameObject> PeopleTiles = new List<GameObject> ();

	// Use this for initialization
	void Start () {

		CloseButton.onClick.AddListener (CloseButtonFunction);
		ShowPeople ();

	}
		

	void CloseButtonFunction(){
		PeopleViewHolder.SetActive (false);
		DestroyPeople ();
	}

	void ShowPeople(){
		int x = 0;
		int y = 0;
		for (int i = 0; i < gameObject.GetComponent<SettlementScript>().People.Count; i++) {
			GameObject Person = Instantiate(PersonHolder) as GameObject;
			PeopleTiles.Add (Person);
			Person.transform.SetParent(InternalHolder.transform);
			Person.transform.localScale = new Vector3 (1,1,1);
			Person.transform.localPosition = new Vector3(-630 + (630 * x),310 - (y * 250),0);
			Person.transform.SetAsFirstSibling ();
			x++;
			if (x > 2) {
				y++;
				x = 0;
			}
		}
	}

	void DestroyPeople(){
		for (int i = 0; i < gameObject.GetComponent<SettlementScript>().People.Count; i++) {
			GameObject.Destroy(PeopleTiles[i]);
			print ("GREG");
		}

	}




}