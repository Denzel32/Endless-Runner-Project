using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour
{
	Transform myTransform;
	public float minSpeed = 5.0f;
	public float maxSpeed = 20.0f;
	int x, y,z;
	public float currentSpeed;

	void Start()
	{
		y = 0;
		z = 0;
		x = 8;
		myTransform = transform;
		myTransform.position = new Vector3(x,y,z);
		currentSpeed = Random.Range (minSpeed, maxSpeed);
	}

	void Update()
	{
		x = 8;
		myTransform.Translate(-Vector3.right * currentSpeed * Time.deltaTime);
		if(myTransform.position.x < - 8)
		{
			myTransform.position = new Vector3(x, y, z);
			currentSpeed = Random.Range (minSpeed, maxSpeed);
		}
	}
	void OnTriggerEnter(Collider collide)
	{
		//Debug.Log("The N word");
		if(collide.gameObject.tag == "PlayerBullet")
		{

			Destroy(this.gameObject);
		}
	}

}
