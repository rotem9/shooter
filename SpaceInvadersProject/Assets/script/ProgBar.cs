using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ProgBar : MonoBehaviour {
	
	public Image progressBar;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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
	}
}
