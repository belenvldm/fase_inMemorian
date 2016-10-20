using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;

/**
* En esta clase va todo lo que sucede en la escena PlantaBaja,
* esto comprende la pb de la casa normal
*/

public class PlantaBaja : MonoBehaviour {

	private bool existsRedTotem = false;
	private Item redTotem;
	public GameObject data;
	private Inventory inventory;

	void Awake()
	{
		data = GameObject.Find ("Data");
		inventory = data.GetComponent<Inventory>();
	}

	
	public void OnTriggerEnter (Collider otherCollider) {

		existsRedTotem = hasRedTotem ();

		if (otherCollider.gameObject.tag == "Player") {
			
			Debug.Log("MEMORIA UNO");

			if(existsRedTotem){
				GoToMemoriaUno ();
			}

		}
	}

	public bool hasRedTotem()
	{
		
		redTotem = inventory.GetItemByName ("totemRed");
		if (redTotem != null) {
			Debug.Log ("TENES TOTEM RED");
			return true;
		} else {
			Debug.Log ("NO TENES TOTEM RED");
			return false;
		}
	}

	void GoToMemoriaUno()
	{
		Debug.Log ("entro GoToMemoriaUno");
		FadeData fadeData = new FadeData();
		fadeData.newScene = "MemoriaUno";
		fadeData.color = Color.black;
		fadeData.duration = 1.5f;
		Events.Fade (fadeData);
	}

}