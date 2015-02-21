using UnityEngine;
using System.Collections;
//test

public class PlayerMovement : MonoBehaviour
	
{
	private Vector3 movementVector;
	private CharacterController characterController;
	private float movementSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 40;
	
	
	void Start()
	{
		characterController = GetComponent<CharacterController>();
	}
	
	
	void Update()
	{
		movementVector.x = 0;
		movementVector.z = 0;
		if(Input.GetButtonDown("A"))
		{
			movementVector.x -= 10*movementSpeed;
		}
		if(Input.GetButtonDown("D"))
		{
			movementVector.x += 10*movementSpeed;
		}

		characterController.Move(movementVector * Time.deltaTime);
		
	}
	
}