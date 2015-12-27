using UnityEngine;
using System.Collections;

public class Flash : MonoBehaviour {

	public static bool flashActive;
	public Texture2D flash;
	private GUIStyle style;
	public float flashing;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (flashActive) {
			flashing += Time.deltaTime;
			if (flashing > 0.05f) {
				flashActive = false;
			}
		}
	}

	public void OnGUI()
	{
		if (flashActive)
		{
			// draw: 
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), flash);
			style = new GUIStyle( GUI.skin.box ); 
			style.normal.background = MakeTex( 2, 2, new Color(1, 1, 1, 1) );
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), "", style);
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
}
