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
		transform.Rotate (0, 0, -6.0f * 10.0f * Time.deltaTime * 0.2f);
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
