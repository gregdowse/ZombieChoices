using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SettlementScript : MonoBehaviour {

	public Button MakePerson;

	public List<PersonClass> People = new List<PersonClass> ();
	// Use this for initialization
	void Start () {
		MakePerson.onClick.AddListener (CallGeneratePerson);

		gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
		gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
		gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
        gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void CallGeneratePerson(){
		gameObject.GetComponent<PersonGenerator> ().GeneratePerson ();
		print (People);
	}
}
