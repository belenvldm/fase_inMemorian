using UnityEngine;
using System.Collections;

public class ActionManager : MonoBehaviour {
    
	void Start () {
        Events.OnCharacterAction += OnCharacterAction;
    }
    void Destroy()
    {
        Events.OnCharacterAction -= OnCharacterAction;
    }
    void OnCharacterAction()
    {
        InteractableObject interactableObject =  GetComponent<DistanceManager>().GetObjectNear();
        if (interactableObject == null) return;
        interactableObject.SetActive();
    }
}
