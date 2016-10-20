using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

/**
* En esta clase va todo lo correspondiente al splash (index) del juego,
* aca iria el logo y un boton "play" o un loading... 
*/

public class Splash : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("PlayGame", 4);
	}

	void PlayGame(){
		FadeData fadeData = new FadeData();
		fadeData.newScene = "CinematicaIni";
		fadeData.color = Color.black;
		fadeData.duration = 1.5f;
		Events.Fade (fadeData);
	}
}