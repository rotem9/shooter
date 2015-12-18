using UnityEngine;
using System.Collections;

public class PowerUp1 : MonoBehaviour {

	public GameObject bear;
	public static bool clicked;
	// Use this for initialization
	void Start () {
		clicked = false;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void clickOnPowerUp1() {
		PowerBar.PowerBarOn = false;
		Instantiate(bear, new Vector2(0f, 5f), Quaternion.identity);
		clicked = true;
	}

	public void mouseOver() {
		PowerBar.PowerBarOn = false;
	}
}
