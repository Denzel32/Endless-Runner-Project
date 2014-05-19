using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {
	public GameObject bullet;
	private Transform myPosition;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{


		if(Input.GetKeyDown ("space"))
		{
			Instantiate(bullet);
		}
	}
}
