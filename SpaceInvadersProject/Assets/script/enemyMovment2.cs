using UnityEngine;
using System.Collections;

public class enemyMovment2 : MonoBehaviour {

	public float movementSpeed = 0.035f;
	public GameObject explotion;
	public float power;
	public bool hit;
	public int hitCounter;

	private AudioSource sourceAudio;
	public AudioClip enemy2dies;
	public AudioClip enemy2hurts;
	public AudioClip enemy2enters;

	// Use this for initialization
	void Start () {
		hit = false;
		sourceAudio = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {

		if (hit) {
			power = PlayerMovement.currPower;
			if (power >= 0.95f) {
				sourceAudio.PlayOneShot(enemy2dies, 1f);
				Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
				Destroy (gameObject);
			} else {
				//insert effect for getting hit but not dying...
				sourceAudio.PlayOneShot(enemy2hurts, 1f);
				hit = false;
				hitCounter += 1;
			}
		}

		if (hitCounter == 2) {
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		}

		if (AtomicBear.hit == true) {
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		}
		if (GirlBehavior.alive) {
			transform.position = new Vector2 (transform.position.x - movementSpeed, transform.position.y - 0.015f);
		}
	}
	
	void OnCollisionEnter2D(Collision2D objectCollision)
	{
		if (objectCollision.gameObject.tag == "bullet") {
			hit = true;
			GameManager.score++;
			//Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			//Destroy (gameObject);
		} else if (objectCollision.gameObject.tag == "girl") {
			Destroy (gameObject);
			
		}
	}
}
