using System;
using UnityEngine;

namespace Script.View.MianClock.Hands
{
	public class HandBase : MonoBehaviour
	{
		private float _targetTheta = 0;
		private float _currentTheta = 0;
		private float vTheta = 0;

		public void TargetTheta(float value)
		{

			var preTheta = _targetTheta;
			_targetTheta = value;
			if ( preTheta  < _targetTheta)
			{
				_currentTheta += 360;
				Debug.Log("hoge");
			}
		}

		public void SetTheta(float value)
		{
			_targetTheta = value;
			_currentTheta = value;
		}
		
		// Use this for initialization
		protected virtual void Start () {
		
		}
	
		// Update is called once per frame
		protected virtual void Update () {
			//transform.rotation =  Quaternion.Euler(0, 0, TargetTheta);
			var aTheta = _targetTheta - _currentTheta;
			vTheta += aTheta * 0.1f - 0.2f * vTheta;
			_currentTheta += vTheta;
			transform.rotation =  Quaternion.Euler(0, 0, _currentTheta);
		}
	}
}
