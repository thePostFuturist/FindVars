using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace VirtualityRipple.Example
{
	public class MiscClassManager : MonoBehaviour, IFindVars
	{

		[SerializeField] private List<MiscClass> _randomClasses = new List<MiscClass>();
		[SerializeField] private Renderer _cube;
		[SerializeField] private Light _pointLight;

		public void FindVars()
		{
			_randomClasses = GetComponentsInChildren<MiscClass>().ToList();
			_cube = GameObject.Find("Cube").GetComponent<Renderer>();
			_pointLight = Object.FindObjectOfType<Light>();
		}

		private void Start()
		{
//			FindVars(); 
			Debug.Log(string.Format("MiscClasses: {0}\nCube: {1}\nPoint Light: {2}", _randomClasses, _cube, _pointLight));
		}
	}
}