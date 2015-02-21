using UnityEngine;
using System.Collections;


public class PlayerMovement : MonoBehaviour
	
{
	private Vector3 movementVector;
	private CharacterController characterController;
	private float movementSpeed = 5;
	private float jumpPower = 15;
	private float gravity = 40;
	public int time = 30;
	
	
	void Start()
	{
		characterController = GetComponent<CharacterController>();
		StartCoroutine (countdown ());
	}
	
	IEnumerator countdown(){
		while (time > 0) {
			movementVector.z -= movementSpeed;
			yield return new WaitForSeconds(60);
			time -=2;
		}
	}
	
	void Update()
	{
		if (movementVector.y > 0) {
			movementVector.y = 0; 
		}
		movementVector.x = 0;
		if(Input.GetButtonDown("left"))
		{
			movementVector.x += 10*movementSpeed;
		}
		if(Input.GetButtonDown("right"))
		{
			movementVector.x -= 10*movementSpeed;
		}
		
		
		characterController.Move(movementVector * Time.deltaTime);
		
	}
	
}