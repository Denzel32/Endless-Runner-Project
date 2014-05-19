using UnityEngine;
using System.Collections;

public class SpawnManager : MonoBehaviour 
{	
	public GameObject Enemy;

	// Use this for initialization
	void Start () 
	{
		Invoke("EnemySpawn", 1f);
	}

	void EnemySpawn()
	{	
		//make the enemy spawn at a certain point 
		Instantiate(Enemy, new Vector3(0, 0, -1),this.transform.rotation);
		//make the enemy spawn every 3 seconds 
		Invoke ("EnemySpawn", 2f);
	}
}
