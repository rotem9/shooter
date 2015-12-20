using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour {
	
	private AudioSource sourceAudio;
	public AudioClip enemy1dies;
	public AudioClip enemy2dies;
	public AudioClip enemy2hurt;
	
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
			sourceAudio.PlayOneShot (enemy2dies, 1f);
			enemyMovment2.playenemy2dies = false;
		}
		
		if (enemyMovment2.playenemy2hurts) {
			sourceAudio.PlayOneShot(enemy2hurt, 1f);
			enemyMovment2.playenemy2hurts = false;
		}
	}
}

