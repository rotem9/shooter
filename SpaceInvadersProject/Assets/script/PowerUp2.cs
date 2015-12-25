using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class PowerUp2 : MonoBehaviour
{

	public static bool clicked = false;
	public static bool press = false;
	public float countdown;

	// Use this for initialization
	void Start ()
	{

	}
	

	// Update is called once per frame
	void Update ()
	{
		if (countdown <= 5.98 && countdown >= 5.95)
			press = false;
		if (clicked == true) {
			countdown -= Time.deltaTime;
			if (countdown <= 0)
				clicked = false;
		}
	}

	public void clickOnPowerUp2 ()
	{
		countdown = 6;
		clicked = true;
		//time = Time.realtimeSinceStartup;
	}

	public void OnMouseDown () {
		press = true;
	}
}
