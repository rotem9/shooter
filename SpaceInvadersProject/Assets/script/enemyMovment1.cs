using UnityEngine;
using System.Collections;


public class enemyMovment1 : MonoBehaviour {

	public float movementSpeed = 0.02f;
	public GameObject explotion;
	public static bool playenemy1dies;
	public static bool playGameOver;
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (AtomicBear.hit == true) {
			playenemy1dies = true;
			Instantiate (explotion, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			GameManager.score++;
			Destroy (gameObject);
		}
		if (GirlBehavior.alive && PowerUp3.clicked == false) {
			anim.enabled = true;
			if (transform.position.x >= 4.6) {
				transform.position = new Vector2 (transform.position.x - movementSpeed, -2.67f);
			} else {
				transform.position = new Vector2 (transform.position.x - movementSpeed, -2.786f);
			}
		} else anim.enabled = false;
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

