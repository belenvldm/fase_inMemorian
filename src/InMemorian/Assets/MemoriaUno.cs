using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* En esta clase va todo lo que pasa en la Memoria 1,
* aca estan los pajaritos, ruinas y corrida a la
* sala blanca
*/

public class MemoriaUno : MonoBehaviour {

	public void ReturnFloor() {
		SceneManager.LoadScene ("PbLavadero");	
	}
}
