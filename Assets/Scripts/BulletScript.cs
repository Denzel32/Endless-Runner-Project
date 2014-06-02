using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour {
	private Transform myTransform;
	private int bulletSpeed = 2;
	private int bulletDamage = 50	;

	void Start()
	{
		myTransform = transform;
	}
	// Update is called once per frame
	void Update () 
	{
		//make the bullet shoot
		myTransform.Translate(Vector3.right * bulletSpeed * Time.deltaTime);

		//destroy the bullet if the x value is greater than 
		if(myTransform.position.x > 8)
		{
			DestroyObject (this.gameObject);

		}
	}
	void OnTriggerEnter(Collider Collide)
	{
		if(Collide.gameObject.tag == "Enemy")
		{	

			Destroy(this.gameObject);
		}

	}
}
