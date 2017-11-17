using System.Collections;
using System.Collections.Generic;
using Script.View.MianClock.Hands;
using UnityEngine;
using UnityEngine.UI;

public class ShortHand : HandBase {
	
	public float Hours
	{
		set
		{
			TargetTheta = -1 * value * 360f / 10f;
		}
	}
	

	// Use this for initialization
	void Start () {
		var texture = Resources.Load("Image/short") as Texture2D;

		var rawImage = this.gameObject.AddComponent<RawImage>();
		rawImage.texture = texture;
		var rectTransform = rawImage.GetComponent<RectTransform>();
		rectTransform.sizeDelta = new Vector2(texture.width, texture.height);
		rectTransform.pivot = new Vector2(0.5f,0.025f);

		transform.rotation =  Quaternion.Euler(0, 0, -45);
		transform.localScale = new Vector3(0.1f,0.1f,1);
	}
	
}
