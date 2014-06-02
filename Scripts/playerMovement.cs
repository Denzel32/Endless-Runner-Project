using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {
	
	public int speed = 10;
	public int gravity = 6;
	public int jumpForce = 300;
	public float jumpSpeed = 3f;
	private bool onGround = true;
	
	void Update()
	{		
		//Fetch Input for movement on the X Axis
		float x = Input.GetAxis("Horizontal");
		
		//Lets you move on the X Axis
		this.transform.Translate(new Vector2(x, 0) * speed * Time.deltaTime);
		
		//If you're on the ground you will be able to jump
		if(onGround == true)
		{
			//If W is pressed you will Jump
			if(Input.GetKeyDown(KeyCode.Space))
			{
				Jump();
			}
		}
	}
	
	//Jump Physics
	void Jump()
	{
		this.transform.rigidbody2D.AddForce(Vector3.up * jumpSpeed * jumpForce);
		onGround = false;
	}
	
	//Checks if you're on the ground
	void OnCollisionEnter2D (Collision2D hit)
	{
		if(hit.transform.tag == "Platforms")
		{
			onGround = true;
		}
	}
}