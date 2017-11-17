using Script.Controller;
using UnityEngine;

namespace Script
{
	public class Main : MonoBehaviour {

		// Use this for initialization
		private void Start ()
		{
			var controllerManager = ControllerManager.Instance;
			controllerManager.transform.parent = this.transform;
		}
	
		// Update is called once per frame
		private void Update () {
			
		
		
		}
	}
}
