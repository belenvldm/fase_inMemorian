using UnityEngine;
using System.Collections;

public class Alacena : InteractableObject {

    override public void OnSetActive()
    {
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
