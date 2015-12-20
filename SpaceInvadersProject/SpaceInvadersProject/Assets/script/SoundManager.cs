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
	public AudioClip powerbear;

	// Use this for initialization
	void Start () {
		sourceAudio = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		if (enemyMovment1.playenemy1dies) {
			sourceAudio.PlayOneShot(enemy1dies, 0.2f);
			enemyMovment1.playenemy1dies = false;
		}
		
		if (enemyMovment2.playenemy2hurts) {
			sourceAudio.PlayOneShot(enemy2hurt, 0.2f);
			enemyMovment2.playenemy2hurts = false;
		}
		
		if (enemyMovment2.playenemy2dies) {
			sourceAudio.PlayOneShot(enemy2dies, 0.2f);
			enemyMovment2.playenemy2dies = false;
		}

		if (Bullet.playhitmonster) {
			sourceAudio.PlayOneShot(toyHitMonster, 0.02f);
			Bullet.playhitmonster = false;
		}

		if (PlayerMovement.playthrow) {
			sourceAudio.PlayOneShot(throwToy, 0.2f);
			PlayerMovement.playthrow = false;
		}

		if (enemyMovment1.playGameOver) {
			sourceAudio.PlayOneShot (gameOver, 0.2f);
			enemyMovment1.playGameOver = false;
		}

		if (PowerUp1.playPowerup) {
			sourceAudio.PlayOneShot(powerbear);
			PowerUp1.playPowerup = false;
		}
	}
}

