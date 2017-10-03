using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour {

	public int ScrollSpeed;
	public int ButtonSpeed;

	// Use this for initialization
	void Start () {
		if (ScrollSpeed == 0) {
			ScrollSpeed = 4;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void UpdateOptions(){
			
	}

}
