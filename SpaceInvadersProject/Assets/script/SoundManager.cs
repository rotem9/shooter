using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	
	private AudioSource sourceAudio;
	public AudioClip enemy1dies;
	public AudioClip enemy2dies;
	public AudioClip enemy2hurt;
	public AudioClip toyHitMonster;
	public AudioClip throwToy;
	public AudioClip wave1;
	public AudioClip wave2;
	public AudioClip wave3;
	public AudioClip wave4;
	public AudioClip wave5;
	public AudioClip atomicbear;
	public AudioClip enemy3dies;
	public AudioClip enemy4dies;
	
	// Use this for initialization
	void Start () {
		sourceAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (enemyMovment1.playenemy1dies) {
			sourceAudio.PlayOneShot(enemy1dies, 1f);
			enemyMovment1.playenemy1dies = false;
		}
		
		if (enemyMovment2.playenemy2hurts) {
			sourceAudio.PlayOneShot(enemy2hurt, 1f);
			enemyMovment2.playenemy2hurts = false;
		}
		
		if (enemyMovment2.playenemy2dies) {
			sourceAudio.PlayOneShot(enemy2dies, 1f);
			enemyMovment2.playenemy2dies = false;
		}

		if (enemyMovment4.enemy4dies) {
			sourceAudio.PlayOneShot(enemy4dies, 1f);
			enemyMovment4.enemy4dies = false;
		}

		if (Bullet.playhitmonster) {
			sourceAudio.PlayOneShot(toyHitMonster, 0.1f);
			Bullet.playhitmonster = false;
		}

		if (enemyMovment3.playdiejump) {
			sourceAudio.PlayOneShot (enemy3dies, 1f);
			enemyMovment3.playdiejump = false;
		}

		if (PlayerMovement.playthrow) {
			sourceAudio.PlayOneShot(throwToy, 1f);
			PlayerMovement.playthrow = false;
		}

		if (PowerUp1.playatomicbear) {
			sourceAudio.PlayOneShot(atomicbear, 1f);
			PowerUp1.playatomicbear = false;
		}

		if (GameManager.playwave1) {
			sourceAudio.PlayOneShot(wave1, 1f);
			GameManager.playwave1 = false;
		}

		if (GameManager.playwave2) {
			sourceAudio.PlayOneShot(wave2, 1f);
			GameManager.playwave2 = false;
		}

		if (GameManager.playwave3) {
			sourceAudio.PlayOneShot(wave3, 1f);
			GameManager.playwave3 = false;
		}

		if (GameManager.playwave4) {
			sourceAudio.PlayOneShot(wave4, 1f);
			GameManager.playwave4 = false;
		}
	}

}


