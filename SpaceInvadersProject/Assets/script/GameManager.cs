using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject alien1; 
    public GameObject alien2;
    public GameObject alien3;

    public Text textScore;

    public static int score = 0;

    public static float movementDirection = 1;
    private float movementSpeed = 0.2f;
    public static float alienXposition;

    public static float alienYPosition;

    private List<GameObject> alienInvasion = new List<GameObject>();

    // Use this for initialization
    void Start () {
        for(int i = 0; i < 6; i++)
        {
            for(int j = 0; j < 4; j++)
            {
                if (i == 0 || i == 3)
                {
                    alienInvasion.Add(Instantiate(alien1, new Vector2(-7 + i*1.2f, j * 1.2f), Quaternion.identity) as GameObject);
                }
                if (i == 1 || i == 4)
                {
                    alienInvasion.Add(Instantiate(alien2, new Vector2(-7 + i * 1.2f, j * 1.2f), Quaternion.identity) as GameObject);
                }
                else
                {
                    alienInvasion.Add(Instantiate(alien3, new Vector2(-7 + i * 1.2f, j * 1.2f), Quaternion.identity) as GameObject);
                }
            }
        }

	}
	
	// Update is called once per frame
	void Update () {
        alienXposition = movementSpeed * movementDirection;

        textScore.text = "score: " + score;
    }
}
