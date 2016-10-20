using UnityEngine;
using System.Collections;

public class RoomManager : MonoBehaviour {

    public Character character;
    public Room room;

    void Start () {
        room.AddCharacter( Instantiate(character) );
    }
}
