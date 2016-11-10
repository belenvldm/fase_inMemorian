using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    private InputManager inputManager;
    private Camera mainCamera;
    public int acceleration;
    public int accelerationRotation;

    public states state;
    public enum states
    {
        ALIVE,
        FREEZE
    }

    void Start () {
        inputManager = Game.Instance.GetComponent<InputManager>();
        mainCamera = GetComponentInChildren<Camera>();
        Events.OnCharacterFreeze += OnCharacterFreeze;
    }
    void Destroy()
    {
        Events.OnCharacterFreeze -= OnCharacterFreeze;
    }
	void OnCharacterFreeze()
    {
        state = states.FREEZE;
    }

    void Update()
    {
        RotateView();
        if (state == states.ALIVE)
        { 
            Traslate();
            RotateBody();
        }
    }
    void RotateView()
    {
        mainCamera.transform.localEulerAngles = inputManager.sightRotation;
    }
    void Traslate()
    {        
        if (inputManager.traslation != 0)
            transform.Translate((Vector3.forward * inputManager.traslation) * (Time.deltaTime * acceleration));
    }
    void RotateBody()
    {
        if (inputManager.direction != 0)
        {
            float angles = inputManager.direction * (Time.deltaTime * (accelerationRotation));
            angles += transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(0, angles, 0);
        }
    }
}
