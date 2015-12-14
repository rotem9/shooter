
using UnityEngine;
using System.Collections;

public class PowerBar : MonoBehaviour
{
	
	public Texture2D progressBarEmpty;
	public Texture2D progressBarFull;
	
	public Vector2 size = new Vector2(20, 60);
	public float speed = 10f;
	public static float barDisplay = 0;
	public static bool PowerBarOn = false;   
	
	// Use this for initialization
	void Start()
	{
	}
	
	public void OnGUI()
	{
		if (PowerBarOn)
		{
			// draw the background:
			GUI.BeginGroup(new Rect(Input.mousePosition.x, Input.mousePosition.y, size.x, size.y));
			GUI.Box(new Rect(0, 0, size.x, size.y), progressBarEmpty);
			
			// draw the filled-in part:
			GUI.BeginGroup(new Rect(0, (size.y - (size.y * barDisplay)), size.x, size.y * barDisplay));
			GUI.Box(new Rect(0, -size.y + (size.y * barDisplay), size.x, size.y), progressBarFull);
			GUI.EndGroup();
			GUI.EndGroup();
		}
	}
	
	// Update is called once per frame
	void Update()
	{
		if (PowerBarOn)
		{
			barDisplay += speed * Time.deltaTime;
			Bullet.power = (int) (barDisplay / Time.deltaTime) * 8;
			
			if (barDisplay >= 1.0f)
			{
				barDisplay = 1.0f;
				speed *= -1;
			}
			else if (barDisplay <= 0)
			{
				barDisplay = 0.0f;
				speed *= -1;
			}
		} else if (!PowerBarOn)
		{
			barDisplay = 0;
		}
	}
	
}