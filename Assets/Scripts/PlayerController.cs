using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField]
	private string horizontalMovement;

	[SerializeField]
	private string verticalMovement;

	private PlayerMovement m_playerMovement;

	void Start () {
		m_playerMovement = GetComponent<PlayerMovement>();
	}
	
	void FixedUpdate () {
		Vector2 input = new Vector2(Input.GetAxisRaw(horizontalMovement), Input.GetAxisRaw(verticalMovement));
		m_playerMovement.Move(input);
	}
}
