using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventScript : MonoBehaviour {

	public Button ContinueButton;

	public GameObject StartView;
	public GameObject MainChoicesView;
	public GameObject EventResultsView;
	public GameObject EventChoicesView;

	public int stage = 0;
	// Use this for initialization
	void Start () {
		ContinueButton.onClick.AddListener (ContinueFunction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ContinueFunction(){
		stage++;

		switch (stage) {
			case 1:
				
				ShowStageOne ();
				break;
			case 2:
				print ("GREG");
				break;
			case 3:
				print ("GREG");
				break;
			case 4:
				print ("GREG");
				break;
			default:
				break;
		}


	}

	public void ShowStart(){
		ResetViews ();
		StartView.SetActive (true);
	}

	public void ShowStageOne(){
		ResetViews ();
		MainChoicesView.SetActive (true);
	}

	public void ShowStageTwo(){

	}

	public void ShowStageThree(){

	}

	public void ShowStageFour(){

	}

	private void ResetViews(){
		StartView.SetActive (false);
		MainChoicesView.SetActive (false);
		EventResultsView.SetActive (false);
		EventChoicesView.SetActive (false);
	}

}
