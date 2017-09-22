using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonGenerator : MonoBehaviour {

	PersonClass Person = new PersonClass();

	public void GeneratePerson(){
		Person.FirstName = "Greg";
		Person.LastName = "Dowse";
		Person.Age = 27;
		Person.Health = 100;
		gameObject.GetComponent<SettlementScript>().People.Add(Person);
	}
}
