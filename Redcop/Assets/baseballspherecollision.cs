using UnityEngine;
using System.Collections;

public class baseballspherecollision : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}
	int damage = 0;
	
	// Update is called once per frame
	//void Update () {
	//
	//}

	void OnTriggerEnter (Collider other)
	{

		damage += 3;
		Debug.Log ("Entered");
	}
	void OnTriggerStay (Collider other)
	{
		damage += 1;
		Debug.Log ("Staying");
	}
	void OnTriggerExit (Collider other)
	{
		Debug.Log ("Exited");
	}

}
