using UnityEngine;
using System.Collections;

public class AtomicBear : MonoBehaviour {

	public static bool hit;
	public GameObject explotion;
	// Use this for initialization
	void Start () {
		hit = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y <= 0f)
			PowerUp1.clicked = false;
		if (transform.position.y <= -2.3f && transform.position.y > -2.5f)
			hit = true;
		if (transform.position.y <= -2.5f) {
			Instantiate (explotion, new Vector2 (transform.position.x, transform.position.y), Quaternion.identity);
			hit = false;
			Destroy (gameObject);
		}
	}
	
}
