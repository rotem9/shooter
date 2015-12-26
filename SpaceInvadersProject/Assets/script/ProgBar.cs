using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour {
	
	public Image progressBar;
	private float fill;
	private float sum;
	private float pieces; 
	public static float mySeconds;

	// Use this for initialization
	void Start () {
		//StartCoroutine (bar());
	}

	public void startTime () {
		StartCoroutine (bar());
	}

	IEnumerator bar() {
		yield return new WaitForSeconds (0.00001f);
				pieces = mySeconds / 0.1f;
				fill = 0.7f / pieces;
				sum = 1f;
		for (float i = pieces; i > 0f; i = i - 1) {
			if (PowerUp3.clicked) 
				yield return new WaitForSeconds (4f);
			sum -= fill;
			progressBar.fillAmount = sum;
			yield return new WaitForSeconds (0.1f);
		}
	}
	
	// Update is called once per frame
	void Update () {
	//	if (max > 0.3f) {
	//		max -= Time.deltaTime / Time.;
	//		change = max;
	//		progressBar.fillAmount = change;

	//	}
	}
}
/**
switch (GameManager.score) {
case(0):
	progressBar.fillAmount = 1f;
	break;
case(1):
	progressBar.fillAmount = 0.95f;
	break;
case(2):
	progressBar.fillAmount = 0.84f;
	break;
case(3):
	progressBar.fillAmount = 0.77f;
	break;
case(4):
	progressBar.fillAmount = 0.68f;
	break;
case(5):
	progressBar.fillAmount = 0.6f;
	break;
case(6):
	progressBar.fillAmount = 0.55f;
	break;
case(7):
	progressBar.fillAmount = 0.5f;
	break;
case(8):
	progressBar.fillAmount = 0.45f;
	break;
case(9):
	progressBar.fillAmount = 0.4f;
	break;
case(10):
	progressBar.fillAmount = 3f;
	break;
default:
	progressBar.fillAmount = 0f;
	break;
}
*/

