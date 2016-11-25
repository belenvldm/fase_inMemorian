using UnityEngine;
using System.Collections;

public class RoomWithDoors : MonoBehaviour {

	int puertasActivas;
	void OnEnable()
	{
		puertasActivas = 0;
	}
	void Start () {
		Game.Instance.GetComponent<RoomManager> ().DoChangeRoom (false);
		Events.FadeReady += FadeReady;
	}
	void OnDestroy () {
		Events.FadeReady -= FadeReady;
	}
	void FadeReady()
	{
		puertasActivas++;

		if (puertasActivas >= 3)
			GameFinished ();
		
		Events.OnCharacterDoorReady ();
		GetComponent<Room> ().AddCharacter (GetComponent<Room> ().character);
	}
	void GameFinished()
	{
		Game.Instance.GetComponent<RoomManager> ().DoChangeRoom (true);
		OnDestroy();
	}
}