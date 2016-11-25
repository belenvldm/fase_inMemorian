using UnityEngine;
using System.Collections;

public class ShaderManager : MonoBehaviour {

	public GameObject camera1;
	public GameObject camera2;

	public enum states
	{
		NONE,
		TWIRL
	}
	void Start () {
		Events.SetShader += SetShader;
		Invoke ("Delay", 1);
	}
	void Delay()
	{
		Events.SetShader (ShaderManager.states.TWIRL);
	}
	void OnDestroy () {
		Events.SetShader -= SetShader;
	}
	void SetShader(states state)
	{
		switch (state) 
		{
		case states.NONE:
			print ("NONE");
			camera1.SetActive (true);
			camera2.SetActive (false);
			break;
		case states.TWIRL:
			print ("TWIRL");
			camera1.SetActive (false);
			camera2.SetActive (true);
			GetComponent<Character> ().mainCamera = camera2.GetComponent<Camera>();
			break;
		}
	}
}
