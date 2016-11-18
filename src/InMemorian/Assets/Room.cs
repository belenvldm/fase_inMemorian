using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour {

    public InteractableObject interactableObject;

    public GameObject[] entrances;
    public GameObject[] dynamicObjects;

    public int MAX_DISTANCE;

    void Start()
    {
        AddInteractableObject(interactableObject);
    }
    public void AddCharacter(Character character)
    {
        int rand = Random.Range(0, entrances.Length);
        Vector3 rotation = entrances[rand].transform.localEulerAngles;
        Vector3 position = entrances[rand].transform.localPosition;

        character.transform.localPosition = position;
        character.transform.localEulerAngles = rotation;

        foreach (GameObject go in entrances)
            go.GetComponentInChildren<MeshRenderer>().enabled = false;
    }
    public void AddInteractableObject(InteractableObject interactableObject)
    {
        int rand = Random.Range(0, dynamicObjects.Length);
        Vector3 rotation = dynamicObjects[rand].transform.localEulerAngles;
        Vector3 position = dynamicObjects[rand].transform.localPosition;

        InteractableObject iObject =  Instantiate(interactableObject);

        iObject.transform.SetParent(transform);

        iObject.transform.localPosition = position;
        iObject.transform.localEulerAngles = rotation;

        foreach (GameObject go in dynamicObjects)
            go.GetComponentInChildren<MeshRenderer>().enabled = false;
    }

}
