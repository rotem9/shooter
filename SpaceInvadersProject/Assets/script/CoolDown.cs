using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class CoolDown : MonoBehaviour {

	public Sprite locked;
	public Sprite pu1;
	public Sprite pu1dis;
	public Sprite pu2;
	public Sprite pu2dis;
	public Sprite pu3;
	public Sprite pu3dis;
	public Button PowerUp1;
	public Button PowerUp2;
	public Button PowerUp3;
	public bool pu1Unlocked;
	public bool pu2Unlocked;
	public bool pu3Unlocked;
	// Use this for initialization
	void Start () {
		if (pu1Unlocked == false) {
			PowerUp1.enabled = false;
			PowerUp1.image.overrideSprite = locked;
		} else {
			PowerUp1.enabled = true;
			PowerUp1.image.overrideSprite = pu1;
		}
		if (pu2Unlocked == false) {
			PowerUp2.enabled = false;
			PowerUp2.image.overrideSprite = locked;
		} else {
			PowerUp2.enabled = true;
			PowerUp2.image.overrideSprite = pu2;
		}
		if (pu3Unlocked == false) {
			PowerUp3.enabled = false;
			PowerUp3.image.overrideSprite = locked;
		} else {
			PowerUp3.enabled = true;
			PowerUp3.image.overrideSprite = pu3;
		}
	}

	// Update is called once per frame
	void Update () {
		if (PowerUp1.enabled == false && pu1Unlocked)
			PowerUp1.image.overrideSprite = pu1dis;
		else if (PowerUp1.enabled)
			PowerUp1.image.overrideSprite = pu1;

		if (PowerUp2.enabled == false && pu2Unlocked)
			PowerUp2.image.overrideSprite = pu2dis;
		else if (PowerUp2.enabled)
			PowerUp2.image.overrideSprite = pu2;

		if (PowerUp3.enabled == false && pu3Unlocked)
			PowerUp3.image.overrideSprite = pu3dis;
		else if (PowerUp3.enabled)
			PowerUp3.image.overrideSprite = pu3;
	}
}
