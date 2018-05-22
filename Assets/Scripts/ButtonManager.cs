using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

	private bool isRedEnabled = false;
	private bool isGreenEnabled = false;
	private bool isBlueEnabled = false;

	private List<Button> redButtons = new List<Button>();
	private List<Button> greenButtons = new List<Button>();
	private List<Button> blueButtons = new List<Button>();

	private List<DoorScript> redDoors = new List<DoorScript>();
	private List<DoorScript> greenDoors = new List<DoorScript>();
	private List<DoorScript> blueDoors = new List<DoorScript>();

	private void Start() {
		Button[] buttons = FindObjectsOfType<Button>();
		DoorScript[] doors = FindObjectsOfType<DoorScript>();
		foreach(Button b in buttons) {
			if(b.color == Button.BUTTON_COLOR.RED){
				redButtons.Add(b);
			}
			else if(b.color == Button.BUTTON_COLOR.GREEN) {
				greenButtons.Add(b);
			}
			else if(b.color == Button.BUTTON_COLOR.BLUE) {
				blueButtons.Add(b);
			}
		}
		foreach(DoorScript d in doors) {
			if(d.color == DoorScript.COLOR.RED){
				redDoors.Add(d);
			}
			else if(d.color == DoorScript.COLOR.GREEN) {
				greenDoors.Add(d);
			}
			else if(d.color == DoorScript.COLOR.BLUE) {
				blueDoors.Add(d);
			}
		}
	}
	
	private void DisableAll() {
		foreach(Button b in redButtons) {
			isRedEnabled = false;
			b.SetButtonActive(isRedEnabled);
		}
		foreach(DoorScript d in redDoors) {
			d.SetDoorActive(false);
		}
		foreach(Button b in greenButtons) {
			isGreenEnabled = false;
			b.SetButtonActive(isGreenEnabled);
		}
		foreach(DoorScript d in greenDoors) {
			d.SetDoorActive(false);
		}
	}

	public void TriggerButton(Button.BUTTON_COLOR color) {
		if(color == Button.BUTTON_COLOR.RED){
			foreach(Button b in redButtons) {
				isRedEnabled = !isRedEnabled;
				b.SetButtonActive(isRedEnabled);
			}
			foreach(DoorScript d in redDoors) {
				d.SetDoorActive(isRedEnabled);
			}
		}
		else if(color == Button.BUTTON_COLOR.GREEN) {
			foreach(Button b in greenButtons) {
				isGreenEnabled = !isGreenEnabled;
				b.SetButtonActive(isGreenEnabled);
			}
			foreach(DoorScript d in greenDoors) {
				d.SetDoorActive(isGreenEnabled);
			}
		}
		else if(color == Button.BUTTON_COLOR.BLUE) {
			foreach(Button b in blueButtons) {
				isBlueEnabled = !isBlueEnabled;
				b.SetButtonActive(isBlueEnabled);
			}
			foreach(DoorScript d in blueDoors) {
				d.SetDoorActive(isBlueEnabled);
			}
		}
	}
}


