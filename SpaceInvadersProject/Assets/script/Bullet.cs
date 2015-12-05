using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.2f);

        if(transform.position.y > 4)
        {
            Destroy(gameObject);
        }
	}

    void OnCollisionEnter2D(Collision2D objectCollision)
    {
        if(objectCollision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
