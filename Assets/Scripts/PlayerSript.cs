using UnityEngine;
using System.Collections;

public class PlayerSript : MonoBehaviour 
{

	private Transform startPosition;
	public int movementSpeed = 5;
	public static int playerLives = 5;
	public static int score = 0;
	float timer = 0f;
	private bool isPaused;

	//reference to the bullet projectil
	public GameObject Bullet;

	// Use this for initialization
		void Start ()
		{	
			startPosition = transform;
			//spawning point at x, y ,z
			//the position has to be at -3, -3, -1

			startPosition.position = new Vector3 (-3, -3, -1);
			isPaused = false;
		}
	
	// Update is called once per frame
	void Update () 
	{
		//Player has to move left and right
		startPosition.Translate (Vector3.right * movementSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);

			  //When the player goes off the screen it has to appears on the other side.

			if(startPosition.position.x > 10)
			{
				startPosition.position = new Vector3(-10, startPosition.position.y, startPosition.position.z);

			}
			else if(startPosition.position.x < -10)
			{
				startPosition.position = new Vector3(10, startPosition.position.y, startPosition.position.z);
			}

			//press key to shoot

			//when the player presses the designated key, the player will fire a bllet

			if(Input.GetKeyDown("space"))
			{
				Vector3 position = new Vector3(startPosition.position.x, startPosition.position.y, startPosition.position.z);
				Instantiate(Bullet, position, Quaternion.identity);
				audio.Play ();
			}
			
			//prints the score
				//print ("Lives: " + playerLives + " score: " + score + "   Current Time " + Time.time + "Timer to respond" + timer) ;
			if (Time.time - timer > 1)
			{
				renderer.enabled = true;
			}

		//pause the game
		if (Input.GetKeyDown (KeyCode.P))
		{
			Pause();
		}
		}
		//the OnTriggerEnter function to destroy the player when hit
		
		void OnTriggerEnter(Collider collide)
		{	//if the bullet hits the enemy, it has to destroy the enemy
				if (collide.gameObject.tag =="Enemy") 
				{	
					playerLives--;
					renderer.enabled =  false;
					timer = Time.time;
					//if player lives is lower than 1, player gets destroyed
					if(playerLives < 1)
					{
						Destroy (this.gameObject);
						
					}
			if(collide.gameObject.tag == "Boss")
			{
				playerLives --;
			}
			if(playerLives < 1)
			{
				Destroy (this.gameObject);
				
			}


				}
		}
	void OnGUI() 
	{
		if(isPaused)
		{
				GUI.Box(new Rect(100, 50,  Screen.width / 2, Screen.height / 4), "Pause Menu");

			if(GUI.Button(new Rect(100, 50, Screen.width / 5, Screen.height / 6), "Unpause"))
			{
					isPaused = false;
					Pause();
				//Debug.Log ("Unpause button has been clicked");
			}
		}
	}
	void Pause()
	{
		if (Time.timeScale == 1)
		{
			Time.timeScale = 0;
			isPaused = true;
		}else
		{
			Time.timeScale = 1;
			isPaused = false;
		}
	}
}

