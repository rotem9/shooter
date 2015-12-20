
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
	private float mousePosy;
	private GUIStyle style;
	private GUIStyle style2;
	
	// Use this for initialization
	void Start()
	{
	}
	
	public void OnGUI()
	{
		if (PowerBarOn)
		{
			// draw the background:
			mousePosy = Screen.height - Input.mousePosition.y;
			GUI.backgroundColor = Color.white;
			GUI.backgroundColor = Color.white;
			GUI.BeginGroup(new Rect(Input.mousePosition.x - 25, mousePosy - 70, size.x, size.y)); 
			GUI.Box(new Rect(0, 0, size.x, size.y), progressBarEmpty);
			style = new GUIStyle( GUI.skin.box ); 
			style.normal.background = MakeTex( 2, 2, new Color( 0.9333f, 0.5843f, 0.8627f, 1f) );
			GUI.Box(new Rect(0, 0, size.x, size.y), "", style);
			
			// draw the filled-in part:
			GUI.contentColor = Color.white;
			GUI.contentColor = Color.white;
			GUI.BeginGroup(new Rect(0, (size.y - (size.y * barDisplay)), size.x, size.y * barDisplay));
			GUI.Box(new Rect(0, -size.y + (size.y * barDisplay), size.x, size.y), progressBarFull);
			style2 = new GUIStyle( GUI.skin.box ); 
			style2.normal.background = MakeTex( 2, 2, new Color( 0.5921f, 0.4196f, 0.5490f, 1f) );
			GUI.Box(new Rect(0, 0, size.x, size.y), "", style2);
			GUI.EndGroup();
			GUI.EndGroup();
		}
	}

	
	private Texture2D MakeTex( int width, int height, Color col )
	{
		Color[] pix = new Color[width * height];
		for( int i = 0; i < pix.Length; ++i )
		{
			pix[ i ] = col;
		}
		Texture2D result = new Texture2D( width, height );
		result.SetPixels( pix );
		result.Apply();
		return result;
	}
	
	// Update is called once per frame
	void Update()
	{
		if (PowerBarOn)
		{
			barDisplay += 4 * (speed * Time.deltaTime) ;
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