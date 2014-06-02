using UnityEngine;
using System.Collections;

public class planemoving : MonoBehaviour 
{
	private float speed = 0.4f;

	void Update () 
	{
		transform.Translate (-8f * Time.deltaTime, 0f, 0f); // background moving

		//renderer.material.mainTextureOffset = new Vector2 (Time.deltaTime * speed,1);
	}
}
