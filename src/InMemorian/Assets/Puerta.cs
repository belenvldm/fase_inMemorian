using UnityEngine;
using System.Collections;

public class Puerta : InteractableObject {

	void OnCharBack()
	{
		GetComponent<Animation>().Play("closeDoor");
	}
	override public void OnSetActive()
	{
		Events.OnCharacterFreeze();
		GetComponent<Animation>().Play("openDoor");
		StartCoroutine( Transition() );
	}
	IEnumerator Transition()
	{
		yield return new WaitForSeconds(1);
		Events.OnCharacterOpenDoor ();
		FadeData fadeData = new FadeData();
		fadeData.color = Color.black;
		fadeData.duration = 1;
		Events.Fade(fadeData);
		yield return new WaitForSeconds(1);
		OnCharBack ();
	}
}