using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AnimationCharacterController : MonoBehaviour
{

	public float walkSpeed = 10.0f;
	public float sprintSpeed = 15.0f;
	public float sensitivity = 700.0f;
	CharacterController character;
	public GameObject cam;
	float move;
	float rotX;
	float gravity = -9.8f;


	void Start(){
		//LockCursor ();
		character = GetComponent<CharacterController> ();
	}


	void Update(){
		move = Input.GetAxis ("Vertical");
		bool runPressed = Input.GetKey("left shift");

		float speed = walkSpeed;

		if (move < 0) {
			move = 0;
		}

		if (runPressed) {
			speed = sprintSpeed;
		}

		rotX = Input.GetAxis ("Mouse X") * sensitivity;


		Vector3 movement = new Vector3 (0, gravity, move * speed);

		transform.Rotate (0, rotX * Time.deltaTime, 0);

		movement = transform.rotation * movement;
		character.Move (movement * Time.deltaTime);
	}
}
