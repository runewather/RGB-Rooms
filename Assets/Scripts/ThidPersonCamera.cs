using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThidPersonCamera : MonoBehaviour {

	[SerializeField]
	private Transform m_target;

	[SerializeField]
	private float m_distance;

	[SerializeField]
	private float m_height;

	[SerializeField]
	private Vector3 m_angle;

	[SerializeField]
	private bool m_lookToTarget;
	
	[SerializeField]
	private bool m_smooth;

	[SerializeField]
	private float m_smoothFactor;

	private Vector3 m_lastPosition;

	void Start () {
		Vector3 m_lastPosition = m_target.position; 
		m_lastPosition -= new Vector3(0, 0, transform.forward.z) * m_distance;
		m_lastPosition += new Vector3(0f, m_height , 0f);
	}
	
	void FixedUpdate () {
		Vector3 newPosition = m_target.position; 
		newPosition -= new Vector3(0, 0, transform.forward.z) * m_distance;
		newPosition += new Vector3(0f, m_height , 0f); 
		
		transform.position = Vector3.Lerp(m_lastPosition, newPosition, m_smoothFactor);
		m_lastPosition = transform.position;

		if(m_lookToTarget) {
			transform.LookAt(m_target);
		}
		else {
			transform.eulerAngles = m_angle;
		}
	}
}
