using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* En esta clase esta todo lo que sucede en el sotano,
* se empieza a inundar, se corta la luz, 
* esta el cuarto de maquinas
*/

public class Sotano : MonoBehaviour {

	public void OnTriggerEnter (Collider otherCollider) {

		if (otherCollider.gameObject.tag == "Player") {

			SceneManager.LoadScene ("MemoriaTres");
		}
	}
}
