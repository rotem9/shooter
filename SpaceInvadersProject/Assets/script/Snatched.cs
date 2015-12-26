using UnityEngine;
using System.Collections;

public class Snatched : MonoBehaviour {

	public GameObject anim;


	// Use this for initialization
	void Start () {
		Instantiate (anim, new Vector2 (0, -2.7f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ClickOnWave () {
		Application.LoadLevel("LevelOne");
	}

	public void ClickOnGame () {
		Application.LoadLevel("OpeningMenu");
	}
}
