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
	public float startWait;

    public Text textScore;

    public static int score = 0;

    // Use this for initialization
	void Start () {
		StartCoroutine (monsters());
	}

	IEnumerator monsters() {
		//yield return new WaitForSeconds (startWait);

			Vector2 pos1 = new Vector2 (6, -2);
			Instantiate (alien1, pos1, Quaternion.identity);
			yield return new WaitForSeconds (1f);

			Vector2 pos2 = new Vector2 (6, 2);
			Instantiate (alien2, pos2, Quaternion.identity);
			yield return new WaitForSeconds (2f);
			
	}
	// Update is called once per frame
	void Update () {
       textScore.text = "score: " + score;
    }
}
