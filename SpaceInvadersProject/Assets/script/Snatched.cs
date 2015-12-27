using UnityEngine;
using System.Collections;

public class Snatched : MonoBehaviour {

	public GameObject anim;
	public static int level;

	// Use this for initialization
	void Start () {
		Instantiate (anim, new Vector2 (-7, -2.7f), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void ClickOnWave () {
		if (level == 1) 
			Application.LoadLevel ("LevelOne");
		if (level == 2) 
			Application.LoadLevel ("LevelTwo");
		if (level == 3) 
			Application.LoadLevel ("LevelThree");
		if (level == 4) 
			Application.LoadLevel ("LevelFour");

	}

	public void ClickOnGame () {
		Application.LoadLevel("OpeningMenu");
	}
}
