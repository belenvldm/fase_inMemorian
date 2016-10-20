using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PbLavadero : MonoBehaviour {

	public void OnTriggerEnter (Collider otherCollider) {

		if (otherCollider.gameObject.tag == "Player") {
			
			SceneManager.LoadScene ("MemoriaDos");
		}
	}
}
