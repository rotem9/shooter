using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	
	public GameObject bullet;
	public float movementSpeed = 0.1f;
	public GameObject powerBar;
	public static float currPower;
	public static bool playthrow;
	public static bool fired;
	public Animator anim;
	public int throwHash;
	public GameObject ice;
	public GameObject ice2;
	public GameObject ice3;

	
	// Use this for initialization
	void Start () {
	
		fired = false;
		anim = GetComponent<Animator> ();
		throwHash = Animator.StringToHash ("fired");
		//Instantiate (ice, new Vector2(0,0), Quaternion.identity);
		//ice.GetComponent<ParticleSystem> ().enableEmission = true;
		//ice.GetComponent<ParticleSystem> ().Play (true);

	}
	
	// Update is called once per frame
	void Update () {

		if ((PowerUp1.clicked == false) && (PowerUp2.press == false) && (PowerUp3.press == false)&& Input.GetKeyDown(KeyCode.Mouse0)) {
			PowerBar.PowerBarOn = true;
		}
		
		if (Input.GetMouseButtonUp(0) && (PowerUp1.clicked == false) && (PowerUp2.press == false) && (PowerUp3.press == false))
		{
			playthrow = true;
			//fire();
			StartCoroutine (fireee());
			currPower = PowerBar.barDisplay;
			PowerBar.PowerBarOn = false;
			fired = false;
		}

		if (PowerUp3.clicked == true) {
			ice.GetComponent<ParticleSystem>().enableEmission = true;
			
		}
	}
	

	IEnumerator fireee() {

		anim.SetTrigger(throwHash);
		yield return new WaitForSeconds (0.4f);
		Instantiate (bullet, new Vector2 (-3.2f, 0f), Quaternion.identity);
		fired = true;

	}
	
	private void fire()
	{
		Instantiate (bullet, new Vector2 (-3.53f, -1.35f), Quaternion.identity);
		//Instantiate(bullet, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
		fired = true;
	}
}