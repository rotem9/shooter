using UnityEngine;
using System.Collections;

public class enemyMovment4 : MonoBehaviour {
	
	public float movementSpeed = 0.035f;
	public GameObject explotion;
	//public float power;
	//public bool hit;
	//public int hitCounter;
	//public static bool playenemy2dies;
	//public static bool playenemy2hurts;
	public Animator anim;
	public static bool enemy4dies;

	
	// Use this for initialization
	void Start ()
	{
		//hit = false;
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

			//power = PlayerMovement.currPower;
		//	if (power >= 0.95f || PowerUp2.clicked) {
				//playenemy2dies = true;
			//	Instantiate (explotion, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			//	Destroy (gameObject);
			//} //else {
				//insert effect for getting hit but not dying...
				//playenemy2hurts = true;
				//anim.SetBool("hit", true);
				//hit = false;
				//hitCounter += 1;
			//}
		//}
		
		//if (hitCounter == 2) {
		//	playenemy2dies = true;
		//	Instantiate (explotion, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
		//	Destroy (gameObject);
		//}
		
		if (AtomicBear.hit == true) {
			//playenemy2dies = true;
			enemy4dies = true;
			Instantiate (explotion, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			GameManager.score++;
			Destroy (gameObject);
		}
		if (GirlBehavior.alive && PowerUp3.clicked == false) {
			anim.enabled = true;
			if (transform.position.x <= 0f)
				transform.position = new Vector2 (transform.position.x - movementSpeed, transform.position.y - 0.015f);
			else
				transform.position = new Vector2 (transform.position.x - movementSpeed, transform.position.y);
		} else anim.enabled = false;
	}
	
	void OnCollisionEnter2D (Collision2D objectCollision)
	{
		if (objectCollision.gameObject.tag == "bullet") {
			//hit = true;
			enemy4dies = true;
			GameManager.score++;
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		} else if (objectCollision.gameObject.tag == "girl") {
			Destroy (gameObject);
			
		}
	}
}
