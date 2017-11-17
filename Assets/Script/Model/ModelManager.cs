using UnityEngine;

namespace Script.Model
{
	public class ModelManager : MonoBehaviour
	{
		public delegate void CallBack();
		private static ModelManager _instance;
		private CallBack _modelCallBack;
		public void addModelCallBack(CallBack callBack)
		{
			_modelCallBack += callBack;
		}
		public static ModelManager Instance
		{
			get
			{
				if (_instance == null)
				{
					var obj = new GameObject("ModelManager");
					_instance = obj.AddComponent<ModelManager>();
				}
				return _instance;
			}
		}

		// Use this for initialization
		private void Start ()
		{
			_modelCallBack();

		}
	
		// Update is called once per frame
		private void Update () {
		
		}
	}
}
