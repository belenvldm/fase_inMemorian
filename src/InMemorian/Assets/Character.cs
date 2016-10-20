using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour {

    private InputManager inputManager;
    private Camera mainCamera;
    public int acceleration;
    public int accelerationRotation;


    void Start () {
        inputManager = Game.Instance.GetComponent<InputManager>();
        mainCamera = GetComponentInChildren<Camera>();
    }
	
	void Update () {
        mainCamera.transform.localEulerAngles = inputManager.sightRotation;
        if( inputManager.traslation != 0)
            transform.Translate((Vector3.forward * inputManager.traslation) * (Time.deltaTime * acceleration));
        if (inputManager.direction != 0)
        {
            float angles = inputManager.direction * (Time.deltaTime * (accelerationRotation));
            angles += transform.localEulerAngles.y;
            transform.localEulerAngles = new Vector3(0, angles, 0);
            print(angles);
        }
           
    }
}
