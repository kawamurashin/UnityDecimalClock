using System;
using UnityEngine;
using UnityEngine.UI;

namespace Script.View.MianClock.Dail
{
	public class DialManager : MonoBehaviour 
	{

		// Use this for initialization
		private void Start ()
		{
			float radius = 100f;
			int i;
			int n;
			float x;
			float y;
			float theta;
			GameObject obj;
			//
			radius = 130f;
			
			obj = new GameObject("Circle");
			Circle circle = obj.AddComponent<Circle>();
			obj.transform.parent = this.transform;
			circle.Draw(130f,Color.white);
			
			
			obj = new GameObject("CircleLine");
			LineRenderer lineRenderer = obj.AddComponent<LineRenderer>();
			lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
			lineRenderer.SetWidth(10f,10f);
			lineRenderer.SetColors(Color.red, Color.black);
			// 頂点を設定
			n = 144;
			// 頂点の数
			lineRenderer.SetVertexCount(n+1);
			for (i = 0; i <= n; i++)
			{
				theta = -2 * Mathf.PI * i/(n*1f) + 0.5f*Mathf.PI;
				x = radius * Mathf.Cos(theta);
				y = radius * Mathf.Sin(theta);
				var vector = new Vector3(x,y,0);
				lineRenderer.SetPosition(i, vector);
			}

			//
			obj.transform.SetParent(this.transform);
			
			radius = 100f;
			n = 10;
			for (i = 0; i < n; i++)
			{
				obj = new GameObject("Text");
				var tf = obj.AddComponent<Text>();
				tf.text = "" + i;
				tf.fontSize = 48;
				tf.color = Color.black;
				obj.transform.SetParent(this.transform);
			
				Font font = Resources.GetBuiltinResource(typeof(Font),"Arial.ttf")as Font;
				tf.font = font;
				theta = -2 * Mathf.PI * i/(n*1f) +0.5f*Mathf.PI;
				x = radius * Mathf.Cos(theta);
				y = radius * Mathf.Sin(theta);
				obj.transform.position = new Vector3(x,y,0);
				
				var vector = new Vector2(tf.preferredWidth,tf.preferredHeight);
				tf.rectTransform.sizeDelta = vector;

			}
			


		}
	
		// Update is called once per frame
		private void Update () {
		
		}
	}
}
