using UnityEngine;
using System.Collections;

public class GirlBehavior : MonoBehaviour {

	public static bool alive;

	// Use this for initialization
	void Start () {
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D objectCollision)
	{
		if(objectCollision.gameObject.tag == "enemy")
		{
			alive = false;
			Application.LoadLevel("Snatched");
			Destroy(gameObject);
		}
	}
}
