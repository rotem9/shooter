using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject alien1; 
    public GameObject alien2;
    public GameObject alien3;
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

    public Text textScore;

    public static int score = 0;
	public static float counter = 4.0f;

    // Use this for initialization
	void Start () {
		ProgBar.mySeconds = 12.95f;
		StartCoroutine (monsters());
	}

	IEnumerator monsters() {

		Vector2 pos1 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos1, Quaternion.identity);
		yield return new WaitForSeconds (2f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);

		Vector2 pos2 = new Vector2 (6, 2);
		Instantiate (alien1, pos2, Quaternion.identity);
		yield return new WaitForSeconds (1.75f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos3 = new Vector2 (6, 2.5f);
		Instantiate (alien1, pos3, Quaternion.identity);
		yield return new WaitForSeconds (1f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos4 = new Vector2 (6.5f, 1.5f);
		Instantiate (alien2, pos4, Quaternion.identity);
		yield return new WaitForSeconds (1.8f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos5 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos5, Quaternion.identity);
		yield return new WaitForSeconds (1.5f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos6 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos6, Quaternion.identity);
		yield return new WaitForSeconds (1.4f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos7 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos7, Quaternion.identity);
		yield return new WaitForSeconds (1f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos8 = new Vector2 (6, 1.75f);
		Instantiate (alien1, pos8, Quaternion.identity);
		yield return new WaitForSeconds (1.5f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);

		Vector2 pos9 = new Vector2 (6.5f, 1.3f);
		Instantiate (alien2, pos4, Quaternion.identity);
		yield return new WaitForSeconds (1f);

		if (PowerUp3.clicked) 
			yield return new WaitForSeconds (4f);
		
		Vector2 pos10 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos5, Quaternion.identity);
		//yield return new WaitForSeconds (1.5f)
			
	}
	// Update is called once per frame
	void Update () {
       textScore.text = "score: " + score;
    }
}
