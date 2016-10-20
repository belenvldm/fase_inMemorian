using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class cinematicaCaida : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("OnBasement", 2);
	}

	public void OnBasement() {
		SceneManager.LoadScene ("Sotano");
	}
}
