using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PbPp : MonoBehaviour {

	public void OnTriggerEnter (Collider otherCollider) {

		if (otherCollider.gameObject.tag == "Player") {

			SceneManager.LoadScene ("cinematicaCaida");
		}
	}
}
