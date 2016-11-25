using UnityEngine;
using System.Collections;

public class Alacena : InteractableObject {

	private bool ready = false;

    override public void OnSetActive()
    {
		if (ready)
			return;
		ready = true;
        Events.OnCharacterFreeze();
        GetComponent<Animation>().Play("alacenaOn");
        StartCoroutine( Transition() );
    }
    IEnumerator Transition()
    {
        yield return new WaitForSeconds(1);
        FadeData fadeData = new FadeData();
        fadeData.color = Color.black;
        fadeData.duration = 1;
        Events.Fade(fadeData);
    }
}
