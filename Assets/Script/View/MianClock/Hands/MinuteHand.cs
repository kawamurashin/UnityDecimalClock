using UnityEngine;
using UnityEngine.UI;

namespace Script.View.MianClock.Hands
{
   
    public class MinuteHand : HandBase
    {

        /*
        public float Minute
        {
            set
            {
                TargetTheta = -1 * value * 360f / 100f;
            }
        }
        */


/*
        protected override void Update()
        {
            var aTheta = TargetTheta - CurrentTheata;
            vTheta += aTheta * 0.1f - 0.2f * vTheta;
            CurrentTheata += vTheta;
            transform.rotation =  Quaternion.Euler(0, 0, CurrentTheata);
        }
        */

        protected override void Start()
        {
            base.Start();


            var texture = Resources.Load("Image/long") as Texture2D;

            var rawImage = this.gameObject.AddComponent<RawImage>();
            rawImage.texture = texture;
            //his.gameObject.transform.SetParent(canvas.gameObject.transform, false);
            //this.gameObject.transform.localPosition = new Vector3(0, 0, 0);
            var rectTransform = rawImage.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(texture.width, texture.height);
            rectTransform.pivot = new Vector2(0.5f,0.025f);

            transform.rotation =  Quaternion.Euler(0, 0, 45);
            transform.localScale = new Vector3(0.1f,0.1f,1);
        }

    }
}
