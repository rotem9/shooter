using UnityEngine;
using System.Collections;

public class enemyMovment2 : MonoBehaviour {

	private float movementSpeed = 0.05f;

	// Use this for initialization
	void Start () {
		//transform.position = new Vector2 (10, -2);
	}
	
	// Update is called once per frame
	void Update () {

		if (GirlBehavior.alive) {
			transform.position = new Vector2 (transform.position.x - movementSpeed, transform.position.y + 0f);
		}
	}
	
	void OnCollisionEnter2D(Collision2D objectCollision)
	{
		if (objectCollision.gameObject.tag == "bullet") {
			GameManager.score++;
			Destroy (gameObject);
		} else if (objectCollision.gameObject.tag == "girl") {
			Destroy (gameObject);
			
		}
	}
}
