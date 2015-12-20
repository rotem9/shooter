using UnityEngine;
using System.Collections;
using UnityEngine.Audio;

public class enemyMovment1 : MonoBehaviour {

	public float movementSpeed = 0.02f;
	public GameObject explotion;
	private AudioSource sourceaudio;
	public AudioClip enemy1enters;
	public AudioClip enemy1hurt;
	public AudioClip enemy1dies;

	// Use this for initialization
	void Start () {
		sourceaudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (AtomicBear.hit == true) {
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
			GameManager.score++;
			sourceaudio.PlayOneShot(enemy1dies, 1f);
			Instantiate(explotion, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
			Destroy (gameObject);
		} else if (objectCollision.gameObject.tag == "girl") {
			Destroy (gameObject);
		}
    }
}

