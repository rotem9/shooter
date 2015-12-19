using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public GameObject bullet;
	public float movementSpeed = 0.1f;
	public GameObject powerBar;
	public static float currPower;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if ((PowerUp1.clicked == false) && Input.GetKeyDown(KeyCode.Mouse0)) {
			PowerBar.PowerBarOn = true;
		}
		
		if (Input.GetMouseButtonUp(0) && (PowerUp1.clicked == false))
		{
			// insert throwing animation
			fire();
			currPower = PowerBar.barDisplay;
			PowerBar.PowerBarOn = false;
		}
	}
	
	private void fire()
	{
		Instantiate(bullet, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
	}
}