using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartMenuScript : MonoBehaviour {

	public GameObject MainMenuView;
	public GameObject StartView;
	public GameObject DofficultyHolder;
	public GameObject InfoHolder;

	public Button NewGameButton;
	public Button ContinueGameButton;
	public Button LoadGameButton;
	public Button OptionsButton;
	public Button QuitButton;

	// Use this for initialization
	void Start () {
		NewGameButton.onClick.AddListener (NewGameButtonFunction);
		ContinueGameButton.onClick.AddListener (ContinueGameButtonFunction);
		LoadGameButton.onClick.AddListener (LoadGameButtonFunction);
		OptionsButton.onClick.AddListener (OptionsButtonFunction);
		QuitButton.onClick.AddListener (QuitButtonFunction);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void StartMenuShow(bool state){
		//StartMenuView.SetActive (state);
	}

	void NewGameButtonFunction(){
		gameObject.GetComponent<SettlementScript> ().StartNewGame ();
		StartMenuShow (false);
	}

	void ContinueGameButtonFunction(){

	}

	void LoadGameButtonFunction(){

	}

	void OptionsButtonFunction(){

	}

	void QuitButtonFunction(){
		Application.Quit();
	}


}
