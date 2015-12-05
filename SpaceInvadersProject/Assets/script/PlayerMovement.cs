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
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position = new Vector2(transform.position.x + movementSpeed, transform.position.y);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position = new Vector2(transform.position.x - movementSpeed, transform.position.y);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fire();
        }
    }

    private void fire()
    {
        Instantiate(bullet, new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
    }
}
