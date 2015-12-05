using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public GameObject bullet;
    public float movementSpeed = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            // insert throwing animation
            fire();
        }
    }

    private void fire()
    {
        Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }
}
