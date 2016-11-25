using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    private InputManager inputManager;
    public Camera mainCamera;
    public int acceleration;
    public int accelerationRotation;
    public int MAX_DISTANCE;
    public states state;
	public Animation anim;
    public enum states
    {
        ALIVE,
        FREEZE,
		AUTOMOVE
    }

    void Start () {
        inputManager = Game.Instance.GetComponent<InputManager>();
        mainCamera = GetComponentInChildren<Camera>();
        Events.OnCharacterFreeze += OnCharacterFreeze;
		Events.OnCharacterAutomove += OnCharacterAutomove;
		Events.OnCharacterOpenDoor += OnCharacterOpenDoor;
		Events.OnCharacterDoorReady += OnCharacterDoorReady;
    }
    void Destroy()
    {
        Events.OnCharacterFreeze -= OnCharacterFreeze;
		Events.OnCharacterAutomove -= OnCharacterAutomove;
		Events.OnCharacterOpenDoor -= OnCharacterOpenDoor;
		Events.OnCharacterDoorReady -= OnCharacterDoorReady;
    }
	void OnCharacterFreeze()
    {
        state = states.FREEZE;
    }
    public void SetMaxDistance(int _MAX_DISTANCE)
    {
        this.MAX_DISTANCE = _MAX_DISTANCE;
    }
    public void Idle()
    {
        state = states.ALIVE;
    }
    void Update()
    {
		if (state == states.AUTOMOVE)
			return;
		
        RotateView();
        if (state == states.ALIVE)
        { 
            Traslate();
            RotateBody();
        }
        Vector3 pos = transform.localPosition;
        if (pos.x > MAX_DISTANCE)
            pos.x = MAX_DISTANCE;
        else if (pos.x < -MAX_DISTANCE)
            pos.x = -MAX_DISTANCE;

        if (pos.z > MAX_DISTANCE)
            pos.z = MAX_DISTANCE;
        else if (pos.z < -MAX_DISTANCE)
            pos.z = -MAX_DISTANCE;

        transform.localPosition = pos;
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
	void OnCharacterAutomove()
	{
		OnCharacterFreeze ();
		print ("AutoWalk");
		anim.Play("characterAutomove");
		anim ["characterAutomove"].normalizedTime = 0;
	}
	void OnCharacterOpenDoor()
	{
		OnCharacterFreeze ();
	}
	void OnCharacterDoorReady()
	{
		Idle ();
	}
}
