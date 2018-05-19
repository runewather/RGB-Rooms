using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractable : MonoBehaviour {

	void OnTriggerStay(Collider other)
	{
		if(Input.GetKeyDown(KeyCode.Z)) {
			print(other);
			if(other.tag == "Button") {
				other.GetComponent<Button>().ButtonAction();
			}
		}
	}
}
