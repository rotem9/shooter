using UnityEngine;
using System.Collections;

public class PowerUp2 : MonoBehaviour
{

	public static bool clicked = false;
	public float countdown;
	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update ()
	{
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
}
