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
		transform.Rotate (0, 0, 6.0f * 10.0f * Time.deltaTime * 0.27f);
		if (transform.position.y <= 4.5f)
			PowerUp1.clicked = false;
		if (transform.position.y <= -2.3f && transform.position.y > -2.5f)
			hit = true;
		if (transform.position.y <= -2.5f) {
			hit = false;
			Destroy (gameObject);
			Flash.flashActive = true;
		}
	}
	
}
