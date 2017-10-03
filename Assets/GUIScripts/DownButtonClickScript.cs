using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DownButtonClickScript : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	public GameObject ThingMoving; 
	public int Speed;
	public int BreakPoint;
	private bool Moving;

	void Update(){
		var d = Input.GetAxis("Mouse ScrollWheel");
		print (d);
		if (d < 0f) {
			ThingMoving.transform.localPosition += new Vector3 (0,Mathf.Abs(d) * Camera.main.GetComponent<OptionsScript>().ScrollSpeed,0);
		}

		//Improvement, don't always check but set value on options update
		if (Moving) {
			ThingMoving.transform.localPosition += new Vector3 (0,Camera.main.GetComponent<OptionsScript>().ButtonSpeed,0);
		}

		if (ThingMoving.transform.localPosition.y >= BreakPoint) {
			Moving = false;
			ThingMoving.transform.localPosition = new Vector3 (0,BreakPoint,0);
		}
	}

	//Do this when the mouse is clicked over the selectable object this script is attached to.
	public void OnPointerDown(PointerEventData eventData){
		Moving = true;
	}

	public void OnPointerUp(PointerEventData eventData){
		Moving = false;
	}
}
