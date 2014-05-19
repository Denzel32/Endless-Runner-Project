using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {
	public float jumping = 25.0f;
	public float movementSpeed = 10.0f;
    private Transform startPosition;

	//cooldown for shooting
	public float maxCoolTime;
	private bool coolDown = false;
	public float coolInt;

    //adds the bullet the player shoots
    public GameObject PlayerBullet;
	public Transform bulletSpawn;

    void Start()
    {
        startPosition = transform;
        //spawning point at x, y ,z

        startPosition.position = new Vector3(-9, 1, 0);
    }

	void Update () 
	{

		//transform.Translate(5f * Time.deltaTime, 0f, 0f); //player non-stop moving to Right

		if (Input.GetKey(KeyCode.Space))
		{
			transform.Translate(Vector3.up * jumping * Time.deltaTime); // jumping
		}

		if (Input.GetKey("a")) {
			transform.Translate (-Vector3.right * movementSpeed * Time.deltaTime);
		}
		if (Input.GetKey("d")) {
			transform.Translate (Vector3.right * movementSpeed * Time.deltaTime);
		}

        //When the designated key is pressed the player will fire a bullet
		if (Input.GetKeyDown(KeyCode.Mouse0) && coolDown == false)
		{
			//Debug.Log("attack");
			Instantiate(PlayerBullet,bulletSpawn.position,transform.rotation);
			coolDown = true;

		}
		if(coolDown)
		{
			coolInt += Time.deltaTime;
			if(coolInt >= maxCoolTime)
			{
				coolDown = false;
				coolInt = 0;
			}
		}
            
	}
}