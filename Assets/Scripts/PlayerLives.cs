using UnityEngine;
using System.Collections;

public class PlayerLives : MonoBehaviour 
{	
	private int playerLives = 5;

	void OnTriggerEnter(Collider colliding)
	{
		if(playerLives < 1)
		{
			Destroy (this.gameObject);
			
		}
		print(playerLives);
		if(colliding.gameObject.tag=="Enemy")
		{
			playerLives--;

		}
	}

}
