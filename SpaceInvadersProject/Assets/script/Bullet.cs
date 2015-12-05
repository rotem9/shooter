using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	private Rigidbody2D blah;

	// Use this for initialization
	void Start () {
		 blah = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
        //transform.position = new Vector2(transform.position.x + 0.2f, transform.position.y);

		Vector3 sp = Camera.main.WorldToScreenPoint (transform.position);
		Vector3 dir = (Input.mousePosition - sp).normalized;
		blah.AddForce (dir * 50);

        if(transform.position.x > 4 || transform.position.y < -3.5 || transform.position.y > 3.5 || transform.position.x < -4.7)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D objectCollision)
    {
        if(objectCollision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
