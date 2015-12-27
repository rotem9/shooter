using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class L3Manager : MonoBehaviour {

	public GameObject alien1; 
	public GameObject alien2;
	public GameObject alien3;
	public GameObject alien4;
	public Vector2 pos1;
	public Vector2 pos2;
	public Vector2 pos3;
	public Vector2 pos4;
	public Vector2 pos5;
	public Vector2 pos6;
	public Vector2 pos7;
	public Vector2 pos8;
	public Vector2 pos9;
	public Vector2 pos10;
	public float startWait;
	public GameObject wave3;
	public GameObject waveComplete;
	private bool finished;
	public GameObject powerupfreeze;
	public GameObject gotIt;
	public static bool playwave1;
	public static bool playwave2 = false;
	public static bool playwave3 = false;
	public static bool playwave4 = false;
	
	//	public static int score = 0;
	public static float counter = 4.0f;
	
	// Use this for initialization
	void Start () {
		//CoolDown.pu1Unlocked = true;
		ProgBar.mySeconds = 26f + 3.5f;
		Snatched.level = 3;
		PlayerMovement.score = 0;
		//StartCoroutine (monsters());
		//Instantiate (dir, new Vector2 (0, 0), Quaternion.identity);
		//Instantiate (wave1, new Vector2(0,0), Quaternion.identity);
	}
	
	public void gotItFunc() {
		PlayerMovement.go = true;
		StartCoroutine (monsters ());
		Destroy (powerupfreeze);
		Destroy (gotIt);
	}
	
	public void downOnGotit () {
		PlayerMovement.go = true;
	}
	
	IEnumerator monsters() {
		yield return new WaitForSeconds (1f);
		PlayerMovement.go = false;
		playwave3 = true;
		Instantiate (wave3, new Vector2(0,0), Quaternion.identity);
		yield return new WaitForSeconds (2.5f);
		
		Vector2 pos1 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos1, Quaternion.identity);
		yield return new WaitForSeconds (2f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos2 = new Vector2 (6, 1.5f);
		Instantiate (alien4, pos2, Quaternion.identity);
		yield return new WaitForSeconds (0.5f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos3 = new Vector2 (6, 1.4f);
		Instantiate (alien1, pos3, Quaternion.identity);
		yield return new WaitForSeconds (2f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos4 = new Vector2 (6.5f, -2.5f);
		Instantiate (alien1, pos4, Quaternion.identity);
		yield return new WaitForSeconds (2.3f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos5 = new Vector2 (6, -2.5f);
		Instantiate (alien3, pos5, Quaternion.identity);
		yield return new WaitForSeconds (1.5f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos6 = new Vector2 (6, 1.2f);
		Instantiate (alien2, pos6, Quaternion.identity);
		yield return new WaitForSeconds (3f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos7 = new Vector2 (6, 1.3f);
		Instantiate (alien4, pos7, Quaternion.identity);
		yield return new WaitForSeconds (1.5f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos8 = new Vector2 (6, 1.2f);
		Instantiate (alien4, pos8, Quaternion.identity);
		yield return new WaitForSeconds (3.5f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos9 = new Vector2 (6.5f, -2.5f);
		Instantiate (alien1, pos4, Quaternion.identity);
		yield return new WaitForSeconds (1.7f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos10 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos5, Quaternion.identity);
		yield return new WaitForSeconds (1.3f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien3, new Vector2 (6, -2.5f), Quaternion.identity);
		yield return new WaitForSeconds (2f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien1, new Vector2 (6.5f, -2.5f), Quaternion.identity);
		yield return new WaitForSeconds (1.7f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien2, new Vector2 (6, 1.5f), Quaternion.identity);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien3, new Vector2 (6, -2.5f), Quaternion.identity);
		yield return new WaitForSeconds (2f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien1, new Vector2 (6.5f, -2.5f), Quaternion.identity);
		yield return new WaitForSeconds (1f);
		
		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Instantiate (alien4, new Vector2 (6, 1.4f), Quaternion.identity);
		//yield return new WaitForSeconds (1.5f)
		
	}
	// Update is called once per frame
	void Update () {
		if (PlayerMovement.score == 16) {
			PlayerMovement.score = 0;
			Instantiate(waveComplete, new Vector2(0,0), Quaternion.identity);
		}
	}
}