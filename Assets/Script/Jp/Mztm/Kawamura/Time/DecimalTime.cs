using System;
using UnityEngine;

namespace Script.Jp.Mztm.Kawamura.Time
{
    public class DecimalTime
    {
        private static DateTime _dateTime = new DateTime();
        private int _decimalHour = 0;
        private int _decimalMinute = 0;
        private int _decimalSecond = 0;
        private int _decimalMillisecond = 0;

        public static DecimalTime Now
        {
            get
            {
                _dateTime = DateTime.Now;
                //
                var h = _dateTime.Hour;
                var m = _dateTime.Minute;
                var s = _dateTime.Second;
                var ms = _dateTime.Millisecond;

                var decimalTime = new DecimalTime();
                decimalTime.SetDecimalTime(h, m, s, ms);

                return decimalTime;
            }
        }

        public DateTime DateTime
        {
            get
            {
                /*
                var value = _decimalMillisecond + _decimalSecond * 1000 + _decimalMinute * 100 * 1000 + _decimalHour * 10 * 100 * 1000;
                var timeSpan = new TimeSpan(0,0,0,0,value);
                var dateTime = DateTime.Today + timeSpan;
                */
                return _dateTime;
            }
            set
            {
                var h = value.Hour;
                var m = value.Minute;
                var s = value.Second;
                var ms = value.Millisecond;
                SetDecimalTime(h, m, s, ms);
            }
        }

        public int Hour
        {
            get { return _dateTime.Hour; }
        }

        public int DecimalHour
        {
            get { return _decimalHour; }
            set { SetDecimalTime(value, _decimalMinute, _decimalSecond, _decimalMillisecond); }
        }

        public int DecimalMinute
        {
            get { return _decimalMinute; }
            set { SetDecimalTime(_decimalHour, value, _decimalSecond, _decimalMillisecond); }
        }

        public int DecimalSecond
        {
            get { return _decimalSecond; }
            set { SetDecimalTime(_decimalHour, _decimalMinute, value, _decimalMillisecond); }
        }

        public int DecimalMillisecond
        {
            get { return _decimalMillisecond; }
            set { SetDecimalTime(_decimalHour, _decimalMinute, _decimalSecond, value); }
        }

        private void SetDecimalTime(int hour = 0, int minute = 0, int second = 0, int millisecond = 0)
        {
            var now = DateTime.Now;
            _dateTime = new DateTime(now.Year, now.Month, now.Day, hour, minute, second, millisecond);

            float value = (10f * 100 * 100 * 1000) *
                          (((hour * 60 * 60 * 1000) + (minute * (60 * 1000)) + (second * 1000) + millisecond) /
                           (24f * 60 * 60 * 1000));
            _decimalHour = (int) Mathf.Floor(value / (100 * 100 * 1000));
            value = value - _decimalHour * 100 * 100 * 1000;
            _decimalMinute = (int) Mathf.Floor(value / (100 * 1000));
            value = value - _decimalMinute * 100 * 1000;
            _decimalSecond = (int) Mathf.Floor(value / 1000);
            _decimalMillisecond = (int) (value - _decimalSecond * 1000);
        }

        public override string ToString()
        {
            var str = _dateTime.Month + "/" + _dateTime.Day + "/" + _dateTime.Year + " " + _decimalHour + ":" +
                      PlusZero(_decimalMinute) + ":" + PlusZero(_decimalSecond);
            return str;
        }

        private string PlusZero(int value)
        {
            var str = (value + 100).ToString();
            str = str.Substring(str.Length - 2, 2);
            return str;
        }
    }
}