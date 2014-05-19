using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour
{
	private int enemyHealth = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider Collision)
	{
		if(collider.gameObject.tag == "PlayerBullet")
		{

		}

	}
}
