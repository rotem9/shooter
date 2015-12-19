using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Level2 : MonoBehaviour
{
	
	public GameObject alien1;
	public GameObject alien2;
	public Vector2 pos1;
	public Vector2 pos2;
	public Vector2 pos3;
	public Vector2 pos4;
	public Vector2 pos5;
	public Vector2 pos6;
	public Vector2 pos7;
	public Vector2 pos8;
	public float startWait;
	public Text textScore;
	public static int score = 0;
		
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (monsters ());
	}
		
	IEnumerator monsters ()
	{
		//yield return new WaitForSeconds (startWait);

		Vector2 pos1 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos1, Quaternion.identity);
		yield return new WaitForSeconds (4f);
		
		Vector2 pos2 = new Vector2 (6, 2);
		Instantiate (alien2, pos2, Quaternion.identity);
		yield return new WaitForSeconds (3.25f);
		
		Vector2 pos3 = new Vector2 (6, 2.5f);
		Instantiate (alien2, pos3, Quaternion.identity);
		yield return new WaitForSeconds (2.8f);
		
		Vector2 pos4 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos4, Quaternion.identity);
		yield return new WaitForSeconds (3.2f);
		
		Vector2 pos5 = new Vector2 (6, 2);
		Instantiate (alien2, pos5, Quaternion.identity);
		yield return new WaitForSeconds (2.3f);
		
		Vector2 pos6 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos6, Quaternion.identity);
		yield return new WaitForSeconds (2.8f);

		Vector2 pos7 = new Vector2 (6, -2.5f);
		Instantiate (alien1, pos7, Quaternion.identity);
		yield return new WaitForSeconds (2.3f);
		
		Vector2 pos8 = new Vector2 (6, 1.75f);
		Instantiate (alien2, pos8, Quaternion.identity);
		yield return new WaitForSeconds (2f);
			
	}
	// Update is called once per frame
	void Update ()
	{
		textScore.text = "score: " + score;
	}
}