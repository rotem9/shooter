using UnityEngine;
using System.Collections;

public class StartMenu : MonoBehaviour {

	public GameObject comic;
	public GameObject startButton;

	public void clickOnStart () {
		Instantiate (comic, new Vector2 (0, 0), Quaternion.identity);
		Destroy (startButton);
		StartCoroutine (starting());
		//Application.LoadLevel("LevelOne");
	}

	IEnumerator starting() {

		yield return new WaitForSeconds (16f);
		Application.LoadLevel ("LevelOne");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}
}
