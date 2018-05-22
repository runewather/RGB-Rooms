using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour {

	[SerializeField]
	private Transform target;
	[SerializeField]
	private float time;

	public enum COLOR { RED, GREEN, BLUE }

	public COLOR color = COLOR.RED;

	private Rigidbody rb;
	
	private Vector3 initPos;

	void Start () {
		initPos = transform.position;
		rb = GetComponent<Rigidbody>();
	}
	
	public void SetDoorActive(bool isActive) {
		if(isActive) {
			StartCoroutine(OpenDoor());
		}
		else {
			StartCoroutine(CloseDoor());
		}
	}

	IEnumerator OpenDoor() {
		while(Vector3.Distance(transform.position, target.position) >= 0.1f) {
			print(Vector3.Distance(transform.position, target.position));
			transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
			yield return null;
		}
	}

	IEnumerator CloseDoor() {
		while(Vector3.Distance(transform.position, initPos) >= 0.1f) {
			transform.position = Vector3.MoveTowards(transform.position, initPos, 0.05f);
			yield return null;	
		}
	}
}
