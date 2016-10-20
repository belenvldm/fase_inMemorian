using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class OnMemory : MonoBehaviour {

	void Start () {
		//Debug.Log ("aca");
	}
	
	public void OnTriggerEnter (Collider otherCollider) {
		
		if (otherCollider.gameObject.tag == "Player") {

			Debug.Log ("aca");
			SceneManager.LoadScene ("MemoriaUno");
		}
	}
}