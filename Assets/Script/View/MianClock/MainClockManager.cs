using System.Runtime.InteropServices;
using Script.Jp.Mztm.Kawamura.Time;
using Script.View.MianClock.Dail;
using Script.View.MianClock.Hands;
using UnityEngine;
using UnityEngine.UI;

namespace Script.View.MianClock
{
	public class MainClockManager : MonoBehaviour
	{
		private MinuteHand _minuite;
		private SecondHand _second;

		private ShortHand _hours;
		// Use this for initialization
		private void Start ()
		{

			GameObject obj;
				
			obj = new GameObject("DialManager");
			obj.AddComponent<DialManager>();
			obj.transform.parent = this.transform;
			
			obj = new GameObject("minute");
			_minuite = obj.AddComponent<MinuteHand>();
			obj.transform.parent = this.transform;
				
			obj = new GameObject("hour");
			_hours = obj.AddComponent<ShortHand>();
			obj.transform.parent = this.transform;
			//
			obj = new GameObject("second");
			_second = obj.AddComponent<SecondHand>();
			obj.transform.parent = this.transform;
			




		}
	
		// Update is called once per frame
		private void Update ()
		{
			
			var decimalTime = DecimalTime.Now;
			var h = decimalTime.DecimalHour;
			var m = decimalTime.DecimalMinute;
			var s = decimalTime.DecimalSecond;

			_hours.Hours = h;
			_minuite.Minute = m;
			_second.Second = s;
			
			
			//Debug.Log(decimalTime);
		}
	}
}
