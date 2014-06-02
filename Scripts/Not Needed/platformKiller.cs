using UnityEngine;
using System.Collections;

public class platformKiller : MonoBehaviour {

	 void OnCollisionEnter2D(Collision2D col)
	{
		if ( col.gameObject.tag == "Platforms")
		{
			Destroy(col.gameObject);
		}
	}
}