using UnityEngine;
using System.Collections;

public class enemyMovment : MonoBehaviour {

    private float startingPosition;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		if (GirlBehavior.alive) {
			transform.position = new Vector2 (transform.position.x - GameManager.alienXposition, GameManager.alienYPosition);
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
