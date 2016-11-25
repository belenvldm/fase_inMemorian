using UnityEngine;
using System.Collections;

public class RoomAutomatic : MonoBehaviour {

	// Use this for initialization
	void OnEnable () {
		StartCoroutine( DoAction());
	}
	IEnumerator DoAction()
	{
		yield return new WaitForSeconds (1);
		Events.OnCharacterAutomove ();
		yield return new WaitForSeconds (6);

		FadeData fadeData = new FadeData();
		fadeData.color = Color.black;
		fadeData.duration = 1;
		Events.Fade(fadeData);
	}

}