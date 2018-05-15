using UnityEngine;
using UnityEditor;


namespace VirtualityRipple
{
	public class FindVarsEditor
	{
		[MenuItem("Edit/FindVars")]
		private static void FindVars()
		{
			var iFindVarses = InterfaceHelper.FindObjects<IFindVars>();

			foreach (IFindVars iFindVarse in iFindVarses)
			{
				iFindVarse.FindVars();
			}

		}

	}
}