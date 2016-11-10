using UnityEngine;
using System.Collections;

public class InteractableObject : MonoBehaviour {
    
	public void SetActive () {
        print("GLOW");
        OnSetActive();
    }

    virtual public void OnSetActive()
    {
        print("A");
    }

}
