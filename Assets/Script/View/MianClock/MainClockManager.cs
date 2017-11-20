using System;
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
        private void Start()
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
            
            var decimalTime = DecimalTime.Now;
            var h = decimalTime.DecimalHour;
            var m = decimalTime.DecimalMinute;
            var s = decimalTime.DecimalSecond;

            var theta = -1*(s / 100f) * 360f;
            _second.SetTheta(theta);
            theta = -1*((m + (s / 100f)) / 100f) * 360f;
            _minuite.SetTheta(theta);
            theta = -1*((h + m / 100f + (s / 100f) / 100f) / 10f) * 360f;
            _hours.SetTheta(theta);
        }

        // Update is called once per frame
        private void Update()
        {
            var decimalTime = DecimalTime.Now;
            var h = decimalTime.DecimalHour;
            var m = decimalTime.DecimalMinute;
            var s = decimalTime.DecimalSecond;

            var theta = -1*(s / 100f) * 360f;
            _second.TargetTheta(theta);
            theta = -1*((m + (s / 100f)) / 100f) * 360f;
            _minuite.TargetTheta(theta);
            theta = -1*((h + m / 100f + (s / 100f) / 100f) / 10f) * 360f;
            _hours.TargetTheta(theta);
        }
    }
}