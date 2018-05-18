using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private PlayerMovement m_playerMovement;

	void Start () {
		m_playerMovement = GetComponent<PlayerMovement>();
	}
	
	void FixedUpdate () {
		Vector2 input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
		m_playerMovement.Move(input);
	}
}
