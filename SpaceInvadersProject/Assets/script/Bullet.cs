using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
	private Rigidbody2D blah;
	public GameObject explosion;
	public static int power;
	public static bool playhitmonster;
	public static TrailRenderer powerTrail;
	public static Animator anim;
	
	// Use this for initialization
	void Start ()
	{
		anim = GetComponent<Animator> ();

		if (PowerUp2.clicked == true) {
			anim.SetBool ("special", true);
		} 

		powerTrail = GetComponent <TrailRenderer> ();
		powerTrail.enabled = false;

		blah = GetComponent <Rigidbody2D> ();
		Vector3 sp = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 dir = (Input.mousePosition - sp).normalized;
		blah.AddForce (dir * power);

	}
	
	// Update is called once per frame
	void Update ()
	{

		transform.Rotate (0, 0, -6.0f * 10.0f * Time.deltaTime * 3f);
		//transform.position = new Vector2(transform.position.x + 0.2f, transform.position.y);
		if (PlayerMovement.fired) {
			Bullet.powerTrail.enabled = false;
		}

		if (PlayerMovement.currPower >= 0.95f) {
			Bullet.powerTrail.enabled = true;
		}

		if (transform.position.x > 5 || transform.position.y < -3.5 || transform.position.y > 3.5 || transform.position.x < -4.7) {
			Destroy (gameObject);
		}

	}
	
	void OnCollisionEnter2D (Collision2D objectCollision)
	{
		if (objectCollision.gameObject.tag == "enemy") {
			playhitmonster = true;
			if (PowerUp2.clicked == false)
				Destroy (gameObject);
			//Instantiate (explosion, transform.position, Quaternion.identity);
			//Destroy(gameObject);
		}
	}
	
}

