using UnityEngine;
using System.Collections;


public class PlayerMovement2 : MonoBehaviour
	
{
	private Vector3 movementVector1;
	private CharacterController characterController1;
	private float movementSpeed = 8;
	private float jumpPower = 15;
	private float gravity = 40;
	
	
	void Start()
	{
		characterController1 = GetComponent<CharacterController>();
	}
	
	
	void Update()
	{
		movementVector1.x = 0;
		movementVector1.z = 0;
		if(Input.GetButtonDown("left"))
		{
			movementVector1.x -= 10*movementSpeed;
		}
		if(Input.GetButtonDown("right"))
		{
			movementVector1.x += 10*movementSpeed;
		}

		
		characterController1.Move(movementVector1 * Time.deltaTime);
		
	}
	
}