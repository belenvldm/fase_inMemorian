using UnityEngine;
using System.Collections;

public static class Utils {

	public static void RemoveAllChildsIn(Transform container)
	{
		int num = container.transform.childCount;
		for (int i = 0; i < num; i++)
			UnityEngine.Object.DestroyImmediate (container.transform.GetChild (0).gameObject);
	}

	public static void SetBool (string name, bool value)
	{
		PlayerPrefs.SetInt (name, value ? 1 : 0);
	}

	public static bool GetBool (string name)
	{
		return PlayerPrefs.GetInt (name) == 1 ? true : false;
	}

	public static bool GetBool(string name, bool value)
	{
		if (PlayerPrefs.HasKey (name)) {
			return GetBool (name);
		}
		return value;
	}

}
