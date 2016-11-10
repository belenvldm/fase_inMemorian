using UnityEngine;
using System.Collections;

public class Alacena : InteractableObject {

    override public void OnSetActive()
    {
        Events.OnCharacterFreeze();
        GetComponent<Animation>().Play("alacenaOn");
    }
}
