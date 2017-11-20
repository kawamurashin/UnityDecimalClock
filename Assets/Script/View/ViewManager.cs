using Script.View.MianClock;
using UnityEngine;
using UnityEngine.UI;

namespace Script.View
{
    public class ViewManager : MonoBehaviour
    {
        // Use this for initialization
        private void Start()
        {
            GameObject obj;
            
            var canvasObj = new GameObject("Canvas");
            canvasObj.transform.parent = this.transform;
            var canvas = canvasObj.AddComponent<Canvas>();
            canvas.renderMode = RenderMode.WorldSpace;
            canvas.gameObject.transform.localPosition = new Vector3(0, 0, 0);

            var rectTransform = canvas.gameObject.GetComponent<RectTransform>();
            rectTransform.sizeDelta = new Vector2(272, 340);

            obj = new GameObject("MainClockManager");
            obj.AddComponent<MainClockManager>();
            obj.transform.parent = canvasObj.transform;
            
        }

        // Update is called once per frame
        private void Update()
        {
        }
    }
}