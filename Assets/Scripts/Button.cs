using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour {

	public enum BUTTON_COLOR
	{
		RED, GREEN, BLUE
	}

	public BUTTON_COLOR color;

	[SerializeField]
	private bool isEnabled;

	private MeshRenderer mesh;

	private ButtonManager btm;

	private void Start() {
		mesh = GetComponent<MeshRenderer>();
		btm = FindObjectOfType<ButtonManager>();
	}

	public void SetButtonActive(bool state) {
		isEnabled = state;
		ChangeColor();
	}

	private void ChangeColor() 
	{
		if(isEnabled) {
			mesh.material.EnableKeyword("_EMISSION");
		}
		else {
			mesh.material.DisableKeyword("_EMISSION");
		}
	}

	public void ButtonAction() 
	{
		btm.TriggerButton(color);
	}

}
