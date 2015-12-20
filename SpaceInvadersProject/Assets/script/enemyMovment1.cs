using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class enemyMovment1 : MonoBehaviour {

	public float movementSpeed = 0.02f;
	public GameObject explotion;
	public static bool playenemy1dies;
	public static bool playGameOver;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {

		if (AtomicBear.hit == true) {
			playenemy1dies = true;
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		}
		if (GirlBehavior.alive) {
			transform.position = new Vector2 (transform.position.x - movementSpeed, transform.position.y + 0f);
		}
	}

    void OnCollisionEnter2D(Collision2D objectCollision)
    {
        if (objectCollision.gameObject.tag == "bullet") {
			playenemy1dies = true;
			GameManager.score++;		
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		} else if (objectCollision.gameObject.tag == "girl") {
			playGameOver = true;
			Destroy (gameObject);
		}
    }
}

