using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	
	public GameObject bullet;
	public float movementSpeed = 0.1f;
	public GameObject powerBar;
	public static float currPower;
	public static bool playthrow;
	public static bool fired;
	public Animator anim;
	public int throwHash;
	public int aimHash;
	public int threwHash;
	public GameObject ice;
	public int special_throwHash;
	public int special_aimHash;
	private bool specialActive;
	public static bool go = false;
	public static bool wavecompletedcompleted = false;
	public static int score = 0;
	//public static bool playpowerupice;
	
	// Use this for initialization
	void Start ()
	{

		specialActive = false;
		fired = false;
		anim = GetComponent<Animator> ();
		throwHash = Animator.StringToHash ("fire");
		aimHash = Animator.StringToHash ("aim");
		threwHash = Animator.StringToHash ("threw");
		special_throwHash = Animator.StringToHash ("fire_special");
		special_aimHash = Animator.StringToHash ("aim_special");

	}
	
	// Update is called once per frame
	void Update ()
	{

		if ((PowerUp1.clicked == false) && (go == false) && (PowerUp2.press == false) && (PowerUp3.press == false) && Input.GetKeyDown (KeyCode.Mouse0)) {
			PowerBar.PowerBarOn = true;

			if (PowerUp2.clicked == false) {
				anim.SetTrigger (aimHash);
			} else {
				anim.SetTrigger (special_aimHash);
				specialActive = true;
			}
		}
		
		if (Input.GetMouseButtonUp (0) && (go == false) && (PowerUp1.clicked == false) && (PowerUp2.press == false) && (PowerUp3.press == false)) {
			playthrow = true;
			//fire();
			StartCoroutine (fireee ());
			currPower = PowerBar.barDisplay;
			PowerBar.PowerBarOn = false;
			fired = false;
		}

		if (PowerUp3.clicked == true) {
			//playpowerupice = true;
			Instantiate (ice, new Vector2 (0, 0), Quaternion.identity);	
		
		} 

		if (wavecompletedcompleted == true) {
			wavecompletedcompleted = false;
			if (Snatched.level == 1)
				Application.LoadLevel ("LevelTwo");
			if (Snatched.level == 2)
				Application.LoadLevel ("LevelThree");
			if (Snatched.level == 3)
				Application.LoadLevel ("LevelFour");
			if (Snatched.level == 4)  
				Application.LoadLevel ("OpeningMenu");
		}

	}

	IEnumerator fireee ()
	{

		if (specialActive == false) {
			anim.SetTrigger (throwHash);
		} else {
			anim.SetTrigger (special_throwHash);
			specialActive = false;
		}
	
		yield return new WaitForSeconds (0.2f);
		Instantiate (bullet, new Vector2 (-4.3f, -0.5f), Quaternion.identity);
		fired = true;
		anim.SetTrigger (threwHash);

	}
	
	private void fire ()
	{
		Instantiate (bullet, new Vector2 (-3.53f, -1.35f), Quaternion.identity);
		//Instantiate(bullet, new Vector2(transform.position.x + 1, transform.position.y), Quaternion.identity);
		fired = true;
	}
}