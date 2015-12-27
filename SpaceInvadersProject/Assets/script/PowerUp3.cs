using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PowerUp3 : MonoBehaviour
{
	
	public static bool clicked = false;
	public static bool press = false;
	public float countdown;
	public Button button;
	private float timeStamp;
	public float coolDownPeriodInSeconds = 8f;
	public static bool playpowerupice;
	// Use this for initialization
	void Start ()
	{
		
	}
	
	
	// Update is called once per frame
	void Update ()
	{
		if (timeStamp != 0 && timeStamp <= Time.time) {
			button.enabled = true;
			timeStamp = Time.time + 2f;
		}

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
		if (button.enabled) {
			playpowerupice = true;
			countdown = 4;
			clicked = true;
			button.enabled = false;
			timeStamp = Time.time + coolDownPeriodInSeconds;
		}
		//time = Time.realtimeSinceStartup;
	}
	
	public void OnMouseDown ()
	{
		if (button.enabled)
			press = true;
	}
}