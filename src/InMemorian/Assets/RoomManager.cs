using UnityEngine;
using System.Collections;

public class RoomManager : MonoBehaviour {

    public Character character;
    public Room[] rooms;
    private Room room_in_scene;
    private Character character_in_scene;
    private int roomID = 0;

    void Start () {
        Events.FadeReady += FadeReady;
        character_in_scene = Instantiate(character);
        NewRoom();       
    }
    void OnDestroy()
    {
        Events.FadeReady -= FadeReady;
    }
    void FadeReady()
    {
        GameObject.Destroy(room_in_scene.gameObject);
        NewRoom();
        character_in_scene.Idle();
    }
    void NewRoom()
    {
        Room newRoom = GetRoom();
        roomID++;
        room_in_scene = Instantiate(newRoom);
        room_in_scene.AddCharacter(character_in_scene);
        character_in_scene.SetMaxDistance(room_in_scene.MAX_DISTANCE);
    }
    Room GetRoom()
    {
        return rooms[roomID];       
    }
}
