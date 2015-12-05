﻿using UnityEngine;
using System.Collections;

public class enemyMovment : MonoBehaviour {

    private float startingPosition;

	// Use this for initialization
	void Start () {
        startingPosition = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

        if((transform.position.x > 7 && GameManager.movementDirection == 1) || (transform.position.x < -7 && GameManager.movementDirection == -1))
        {
            GameManager.movementDirection = -1 * GameManager.movementDirection;
            GameManager.alienYPosition += 0.2f;
        }

        transform.position = new Vector2(transform.position.x + GameManager.alienXposition, startingPosition - GameManager.alienYPosition);
	}

    void OnCollisionEnter2D(Collision2D objectCollision)
    {
        if (objectCollision.gameObject.tag == "bullet")
        {
            GameManager.score++;
            Destroy(gameObject);
        }
    }

}
