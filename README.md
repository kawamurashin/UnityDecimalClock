# UnityDecimalClock
10進法時計 for Unity

DecimalTime Class
10進法時間　時
DecimalTime.Now.DecimalHour
10進法時間　分
DecimalTime.Now.DecimalMinute
10進法時間　秒
DecimalTime.Now.DecimalSecond
10進法時間　ミリ秒
DecimalTime.Now.DecimalMillisecond;

DateTimeも取れるようにしました。
日付を取るときに使います。
DecimalTime.Now.DateTime


例
DecimalTime decimalTime = DecimalTime.Now;
string now = "DecimalTime : " + decimalTime.DateTime.Day + "/" + (decimalTime.DateTime.Month+1f)+"/" + decimalTime.DateTime.Year + ", " +
decimalTime.DecimalHour + ":" + decimalTime.DecimalMinute + ":" + decimalTime.DecimalSecond;
