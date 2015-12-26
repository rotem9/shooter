using UnityEngine;
using System.Collections;

public class SnatchBehavior : MonoBehaviour {

	public float movementSpeed = 0.02f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector2 (transform.position.x + movementSpeed, -2.67f);

		if (transform.position.x > 10)
			Destroy (gameObject);
	}
}
