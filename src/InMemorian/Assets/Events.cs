using UnityEngine;
using System.Collections;

public static class Events
{
	public static System.Action<string> OnGetItem = delegate { };
	public static System.Action<string, int> OnGetItems = delegate { };
	public static System.Action<string> OnDestroyItem = delegate { };
	public static System.Action<FadeData> Fade = delegate { };
	public static System.Action<string> OnSoundFX = delegate { };
	public static System.Action<string> OnMusic = delegate { };

	public static System.Action InventoryRefresh = delegate { };
}
