using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* Clase para la cinematica inicial,
* corre en el bosque.
*/

public class cinematicaIni : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("iniciarJuego", 6);
	}

	void iniciarJuego(){
		FadeData fadeData = new FadeData();
		fadeData.newScene = "PlantaBaja";
		fadeData.color = Color.black;
		fadeData.duration = 1.5f;
		Events.Fade (fadeData);
	}
}