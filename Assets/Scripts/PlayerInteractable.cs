using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour {

	[SerializeField]
	private string interact;
	
	void OnTriggerStay(Collider other)
	{
		if(Input.GetButtonDown(interact)) {
			print(other);
			if(other.tag == "Button") {
				other.GetComponent<Button>().ButtonAction();
			}
		}
	}
}
