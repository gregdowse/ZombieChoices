using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettlementScript : MonoBehaviour {

	public int TheTime;

	public int Supplies;
	public int Defences;

	public List<PersonClass> People = new List<PersonClass> ();



	public Button MenuButton;

	public Button ScavengeButton;
	public Button DefenceButton;
	public Button CropsButton;
	public Button SkipButton;

	public Button PeopleButton;



	// Use this for initialization
	void Start () {
		MenuButton.onClick.AddListener (MenuButtonFunction);
		ScavengeButton.onClick.AddListener (ScavengeButtonFunction);
		DefenceButton.onClick.AddListener (DefenceButtonFunction);
		CropsButton.onClick.AddListener (CropsButtonFunction);
		SkipButton.onClick.AddListener (SkipButtonFunction);
		PeopleButton.onClick.AddListener (PeopleButtonFunction);
	}
	


	void Update () {
		
	}


	public void UpdatePeopleView(){

	}


	void MenuButtonFunction(){
	
	}

	void ScavengeButtonFunction(){
		
	}

	void DefenceButtonFunction(){

	}

	void CropsButtonFunction(){

	}

	void SkipButtonFunction(){
		TheTime++;
	}

	void PeopleButtonFunction(){

	}





}
