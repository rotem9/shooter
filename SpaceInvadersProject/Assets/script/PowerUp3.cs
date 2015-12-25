using UnityEngine;
using System.Collections;

public class PowerUp3 : MonoBehaviour {
	
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
		if (countdown <= 3.98 && countdown >= 3.95)
			press = false;
		if (clicked == true) {
			countdown -= Time.deltaTime;
			if (countdown <= 0)
				clicked = false;
		}
	}
	
	public void clickOnPowerUp3 ()
	{
		countdown = 4;
		clicked = true;
		//time = Time.realtimeSinceStartup;
	}
	
	public void OnMouseDown () {
		press = true;
	}
}