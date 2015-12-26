using UnityEngine;
using System.Collections;

public class CompleteWave : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (wait());
	}

	IEnumerator wait() {
		
		yield return new WaitForSeconds (3.5f);
		Destroy (gameObject);

	}

	// Update is called once per frame
	void Update () {
	
	}
}
