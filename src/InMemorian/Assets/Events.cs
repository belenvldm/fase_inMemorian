using UnityEngine;
using System.Collections;

public static class Events
{
	public static System.Action<string> OnGetItem = delegate { };
	public static System.Action<string, int> OnGetItems = delegate { };
	public static System.Action<string> OnDestroyItem = delegate { };
	public static System.Action<FadeData> Fade = delegate { };
    public static System.Action FadeReady = delegate { };
    public static System.Action<string> OnSoundFX = delegate { };
	public static System.Action<string> OnMusic = delegate { };

	public static System.Action InventoryRefresh = delegate { };
    public static System.Action OnCharacterAction = delegate { };
	public static System.Action OnCharacterOpenDoor = delegate { };
	public static System.Action OnCharacterDoorReady = delegate { };
    public static System.Action OnCharacterFreeze = delegate { };
	public static System.Action OnCharacterAutomove = delegate { };
    public static System.Action ChangeRoom = delegate { };
    public static System.Action<Character> OnWallTrigger = delegate { };

	public static System.Action<ShaderManager.states> SetShader = delegate { };

}
