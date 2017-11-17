using UnityEngine;

namespace Script.View.MianClock.Hands
{
	public class HandBase : MonoBehaviour
	{
		protected float TargetTheta = 0;
		protected float CurrentTheata = 0;
		protected float vTheta = 0;
		// Use this for initialization
		protected virtual void Start () {
		
		}
	
		// Update is called once per frame
		protected virtual void Update () {
			
			
			transform.rotation =  Quaternion.Euler(0, 0, TargetTheta);
		}
	}
}
