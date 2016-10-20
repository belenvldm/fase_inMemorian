using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour {

    public GameObject[] entrances;

	public void AddCharacter(Character character)
    {
        int rand = Random.Range(0, entrances.Length);
        Vector3 rotation = entrances[rand].transform.localEulerAngles;
        Vector3 position = entrances[rand].transform.localPosition;

        character.transform.localPosition = position;
        character.transform.localEulerAngles = rotation;

        foreach (GameObject go in entrances)
        {

        }
    }

}
