﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject alien1; 
    public GameObject alien2;
    public GameObject alien3;

    public Text textScore;

    public static int score = 0;

    public static List<GameObject> alienInvasion = new List<GameObject>();

    // Use this for initialization
	void Start () {
        alienInvasion.Add(Instantiate(alien1, new Vector2(6,5), Quaternion.identity) as GameObject);
		//alienInvasion.Add(Instantiate(alien1, new Vector2(1,7), Quaternion.identity) as GameObject);
        //alienInvasion.Add(Instantiate(alien2, new Vector2(6,5), Quaternion.identity) as GameObject);
        //alienInvasion.Add(Instantiate(alien3, new Vector2(7,5), Quaternion.identity) as GameObject);
	}
	
	// Update is called once per frame
	void Update () {
       textScore.text = "score: " + score;
    }
}