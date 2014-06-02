using UnityEngine;
using System.Collections;

public class backgroundOffset : MonoBehaviour {
	public float speed = 0;
	public static backgroundOffset current;

	float pos = 0;

	/*void Start () 
	{
		current = this;
	}*/

	void Update () 
	{
		pos += speed * Time.deltaTime;
		if(pos > 1.0f)
			pos = 0f;

		renderer.material.mainTextureOffset = new Vector2 (pos, 0);
	}
}
