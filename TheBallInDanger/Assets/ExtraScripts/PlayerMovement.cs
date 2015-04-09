using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float speed;
	float jumpHeight;

	//private bool isFalling = false;
    public KeyCode jumpKey;

	void FixedUpdate () 
	{
		float moveH = Input.GetAxis ("Horizontal");
		float moveV = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveH, 0.0f, moveV);

		GetComponent<Rigidbody>().AddForce (movement * speed * Time.deltaTime);
	}

	void Update () 
	{

		//if (Input.GetKeyDown(KeyCode.W) && isFalling == false)
		//{
		//	gameObject.rigidbody.velocity.y = jumpHeight;
		//}
		//isFalling = true;
	}
	
	//void  OnCollisionStay (){
	//	isFalling = false;
   //}
}
