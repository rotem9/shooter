using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public GameObject bullet;
	public float movementSpeed = 0.1f;
	public GameObject powerBar;
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			PowerBar.PowerBarOn = true;
		}
		
		if (Input.GetMouseButtonUp(0))
		{
			// insert throwing animation
			fire();
			PowerBar.PowerBarOn = false;
		}
	}
	
	private void fire()
	{
		Instantiate(bullet, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
	}
}