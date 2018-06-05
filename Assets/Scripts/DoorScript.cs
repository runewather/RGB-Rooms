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

	private bool isMoving = false;

	void Start () {
		initPos = transform.position;
		rb = GetComponent<Rigidbody>();
	}
	
	public void SetDoorActive(bool isActive) {
		if (!isMoving) 
		{	
			if(isActive) {
			StartCoroutine(OpenDoor());
			}
			else {
				StartCoroutine(CloseDoor());
			}
		}
	}

	IEnumerator OpenDoor() {
		isMoving = true;
		while(Vector3.Distance(transform.position, target.position) >= 0.1f) {
			transform.position = Vector3.MoveTowards(transform.position, target.position, 0.05f);
			yield return null;
		}
		isMoving = false;
	}

	IEnumerator CloseDoor() {
		isMoving = true;
		while(Vector3.Distance(transform.position, initPos) >= 0.1f) {
			transform.position = Vector3.MoveTowards(transform.position, initPos, 0.05f);
			yield return null;	
		}
		isMoving = false;
	}
}
