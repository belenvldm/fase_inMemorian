using UnityEngine;
using System.Collections;

public class RoomManager : MonoBehaviour {

    public Character character;
    public Room[] rooms;
    private Room room_in_scene;
    private Character character_in_scene;
    private int roomID = 0;
	private bool changeRoom;

    void Start () {
        Events.FadeReady += FadeReady;
        character_in_scene = Instantiate(character);
        NewRoom(); 
		changeRoom = true;
    }
    void OnDestroy()
    {
        Events.FadeReady -= FadeReady;
    }
	public void DoChangeRoom(bool changeRoom)
	{
		this.changeRoom = changeRoom;
	}
    void FadeReady()
    {
		if (!changeRoom)
			return;
        GameObject.Destroy(room_in_scene.gameObject);
        NewRoom();
        character_in_scene.Idle();
    }
    void NewRoom()
    {
		Events.SetShader (ShaderManager.states.NONE);
        Room newRoom = GetRoom();
        roomID++;
        room_in_scene = Instantiate(newRoom);
        room_in_scene.AddCharacter(character_in_scene);
        character_in_scene.SetMaxDistance(room_in_scene.MAX_DISTANCE);
    }
    Room GetRoom()
    {
		if (roomID > rooms.Length - 1) {
			roomID = 0;
			Events.SetShader (ShaderManager.states.TWIRL);
		}
        return rooms[roomID];       
    }
}
