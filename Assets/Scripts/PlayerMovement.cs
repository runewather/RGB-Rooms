using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	[SerializeField]
	private float speed;

	private Rigidbody m_rb;

	void Start () {
		m_rb = GetComponent<Rigidbody>();
	}

	public void Move(Vector2 input) {
		Vector3 normalizedInput = Vector3.Normalize(input); 
		if(normalizedInput.magnitude > 0){
			transform.eulerAngles = new Vector3(0, Mathf.Atan2(normalizedInput.x, normalizedInput.y) * Mathf.Rad2Deg, 0);
		}
		m_rb.MovePosition(m_rb.position + new Vector3(normalizedInput.x , 0 , normalizedInput.y) * speed * Time.deltaTime);
	}

	private void OnDrawGizmos() {
		Gizmos.color = Color.yellow;
		Gizmos.DrawLine(transform.position, transform.position + transform.forward * 3);
	}

}
