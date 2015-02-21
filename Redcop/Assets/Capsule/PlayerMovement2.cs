using UnityEngine;
using System.Collections;


public class PlayerMovement2 : MonoBehaviour
	
{
	private Vector3 movementVector1;
	private CharacterController characterController1;
	private float movementSpeed = 5;
	private float jumpPower = 15;
	private float gravity = 40;
	public int time = 30;
	
	
	void Start()
	{
		characterController1 = GetComponent<CharacterController>();
		StartCoroutine (countdown ());
	}

	IEnumerator countdown(){
		while (time > 0) {
			movementVector1.z += movementSpeed;
			yield return new WaitForSeconds(60);
			time -=2;
		}
	}
	
	void Update()
	{
		if (movementVector1.y > 0) {
			movementVector1.y = 0; 
		}
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
		if(Input.GetButtonDown("up"))
		{
			movementVector1.y -= 10*movementSpeed;
		}
		if(Input.GetButtonDown("down"))
		{
			movementVector1.y += 10*movementSpeed;
		}
		
		characterController1.Move(movementVector1 * Time.deltaTime);
		
	}
	
}