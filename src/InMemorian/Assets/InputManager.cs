using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour {

    public Vector2 sightRotation;

    // -1 a 1
    public float direction;

    // -1 a 1
    public float traslation;

	void Update () {
        float _x = Input.mousePosition.y / 2;
        float _y = Input.mousePosition.x / 2;
        _x -= 90;
        _y -= 90;
        sightRotation = new Vector2(_x * -1, _y);

        if (Input.GetKey(KeyCode.RightArrow))
            direction = 1;
        else if (Input.GetKey(KeyCode.LeftArrow))
            direction = -1;
        else
            direction = 0;

        if (Input.GetKey(KeyCode.UpArrow))
            traslation = 1;
        else if (Input.GetKey(KeyCode.DownArrow))
            traslation = -1;
        else
            traslation = 0;

        if (Input.GetKeyDown(KeyCode.Space))
            Events.OnCharacterAction();
    }
}
