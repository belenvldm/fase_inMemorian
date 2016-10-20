using UnityEngine;
using System.Collections;

public class ItemPickUp : MonoBehaviour {

	public Item item;
	public bool isTaken;
	public string ItemNameTaken;

	private Game Game;

	public void Init(Game game)
	{
		this.Game = game;
		ItemNameTaken = item.itemName + ".isTaken";
		if (PlayerPrefs.HasKey (ItemNameTaken)) {
			isTaken = Utils.GetBool (ItemNameTaken);
		} else {
			isTaken = false;
		}
		if (isTaken) {
			gameObject.SetActive (false);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		//GameObject.Find("Player").GetComponent<FirstPersonController>().enabled = false;
		isTaken = true;
		Utils.SetBool (ItemNameTaken, true);
		Destroy(gameObject);
		Game.GetComponent<ItemsManager>().GetItem(item.itemName);
	}

}