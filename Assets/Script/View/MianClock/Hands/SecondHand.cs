using System;
using Script.View.MianClock.Hands;
using UnityEngine;
using UnityEngine.UI;

public class SecondHand : HandBase
{
	private float _second = 0;


	
/*
	protected override void Update()
	{
		var aTheta = TargetTheta - CurrentTheata;
		vTheta += aTheta * 0.1f - 0.2f * vTheta;
		CurrentTheata += vTheta;
		transform.rotation =  Quaternion.Euler(0, 0, CurrentTheata);

	}
*/
	// Use this for initialization
	void Start () {

		var texture = Resources.Load("Image/second") as Texture2D;

		var rawImage = this.gameObject.AddComponent<RawImage>();
		rawImage.texture = texture;
		var rectTransform = rawImage.GetComponent<RectTransform>();
		rectTransform.sizeDelta = new Vector2(texture.width, texture.height);
		rectTransform.pivot = new Vector2(0.5f,0.15f);

		transform.localScale = new Vector3(0.1f,0.1f,1);
	}

}
