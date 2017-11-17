using Script.Model;
using Script.View;
using UnityEngine;

namespace Script.Controller
{
	public class ControllerManager : MonoBehaviour
	{
		private static ControllerManager _instance;

		public static ControllerManager Instance
		{
			get
			{
				if (_instance == null)
				{
					var obj = new GameObject("ControllerManager");
					_instance = obj.AddComponent<ControllerManager>();
				}
				return _instance;
			}
		}
		// Use this for initialization
		private void Start () {
			var modelManager = ModelManager.Instance;
			modelManager.gameObject.transform.parent = this.transform;
			modelManager.addModelCallBack(modelCallBackHanlder);
		}

		private void modelCallBackHanlder()
		{
			var obj = new GameObject("ViewManager");
			obj.AddComponent<ViewManager>();
			obj.transform.parent = this.transform;
		}

		// Update is called once per frame
		private void Update () {
		
		}
	}
}
