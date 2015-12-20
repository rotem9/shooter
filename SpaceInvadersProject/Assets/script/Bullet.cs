using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Rigidbody2D blah;
	
	public GameObject explosion;
	public static int power;
	public static bool playhitmonster;
	public static TrailRenderer powerTrail;
	
	// Use this for initialization
	void Start () {
		powerTrail = GetComponent <TrailRenderer> ();
		powerTrail.enabled = false;

		blah = GetComponent <Rigidbody2D> ();
		Vector3 sp = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 dir = (Input.mousePosition - sp).normalized;
		blah.AddForce (dir * power);
	}
	
	// Update is called once per frame
	void Update () {
		//transform.position = new Vector2(transform.position.x + 0.2f, transform.position.y);
		if (PlayerMovement.fired) {
			Bullet.powerTrail.enabled = false;
		}

		if (PlayerMovement.currPower >= 0.95f) {
			Bullet.powerTrail.enabled = true;
		}

		if(transform.position.x > 4 || transform.position.y < -3.5 || transform.position.y > 3.5 || transform.position.x < -4.7)
		{
			Destroy(gameObject);
		}
	}
	
	void OnCollisionEnter2D(Collision2D objectCollision)
	{
		if(objectCollision.gameObject.tag == "enemy")
		{
			playhitmonster = true;
			Destroy(gameObject);
			//Instantiate (explosion, transform.position, Quaternion.identity);
			//Destroy(gameObject);
		}
	}
	
}

