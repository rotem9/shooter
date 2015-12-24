using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	
	private AudioSource sourceAudio;
	public AudioClip enemy1dies;
	public AudioClip enemy2dies;
	public AudioClip enemy2hurt;
	public AudioClip toyHitMonster;
	public AudioClip throwToy;
	public AudioClip gameOver;
	public AudioClip atomicbear;
	
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

		if (Bullet.playhitmonster) {
			sourceAudio.PlayOneShot(toyHitMonster, 0.1f);
			Bullet.playhitmonster = false;
		}

		if (PlayerMovement.playthrow) {
			sourceAudio.PlayOneShot(throwToy, 1f);
			PlayerMovement.playthrow = false;
		}

		if (enemyMovment1.playGameOver) {
			sourceAudio.PlayOneShot (gameOver, 1f);
			enemyMovment1.playGameOver = false;
		}

		if (PowerUp1.playatomicbear) {
			sourceAudio.PlayOneShot(atomicbear, 1f);
			PowerUp1.playatomicbear = false;
		}

	}

}

