using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUp1 : MonoBehaviour {

	public GameObject bear;
	public static bool clicked;
	public static bool playatomicbear;
	public Button button;
	private float timeStamp;
	public float coolDownPeriodInSeconds = 8f;



	// Use this for initialization
	void Start () {
		clicked = false;

	
	}
	
	// Update is called once per frame
	void Update () {
		if (timeStamp != 0 && timeStamp <= Time.time) {
			button.enabled = true;
			timeStamp = Time.time + 2f;
		}
	}

	public void clickOnPowerUp1() {
		if (button.enabled) {
			playatomicbear = true;
			//PowerBar.PowerBarOn = false;
			Instantiate (bear, new Vector2 (0f, 5f), Quaternion.identity);
			clicked = true;
			button.enabled = false;
			timeStamp = Time.time + coolDownPeriodInSeconds;
		}
	}

	public void OnMouseDown() {
		if (button.enabled) {
			clicked = true;
			//PowerBar.PowerBarOn = false;
		}
	}
}
