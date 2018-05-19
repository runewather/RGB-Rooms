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

	private void Start() {
		Button[] buttons = FindObjectsOfType<Button>();
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
	}

	public void TriggerButton(Button.BUTTON_COLOR color) {
		if(color == Button.BUTTON_COLOR.RED){
				foreach(Button b in redButtons) {
					isRedEnabled = !isRedEnabled;
					b.SetButtonActive(isRedEnabled);
				}
			}
			else if(color == Button.BUTTON_COLOR.GREEN) {
				foreach(Button b in greenButtons) {
					isGreenEnabled = !isGreenEnabled;
					b.SetButtonActive(isGreenEnabled);
				}
			}
			else if(color == Button.BUTTON_COLOR.BLUE) {
				foreach(Button b in blueButtons) {
					isBlueEnabled = !isBlueEnabled;
					b.SetButtonActive(isBlueEnabled);
				}
			}
	}
}


