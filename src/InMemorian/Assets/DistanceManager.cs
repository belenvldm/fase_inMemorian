using UnityEngine;
using System.Collections;

public class DistanceManager : MonoBehaviour {

    public Collider area;
    private InteractableObject interactableObject;

    void Start () {
	
	}
    void OnTriggerEnter(Collider other)
    {
        interactableObject = other.GetComponent<InteractableObject>();
    }
    void OnTriggerExit(Collider other)
    {
        interactableObject = null;
    }
    public InteractableObject GetObjectNear()
    {
        return interactableObject;
    }
}
