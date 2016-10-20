using UnityEngine;
using System.Collections;

public class ItemsManager : MonoBehaviour {

	public int totemRedQty;
	public int totemBlueQty;
	public int totemYellowQty;

	void Start()
	{

		totemRedQty = PlayerPrefs.GetInt ("totemRedQty", 0);
		totemBlueQty = PlayerPrefs.GetInt ("totemBlueQty", 0);
		totemYellowQty = PlayerPrefs.GetInt ("totemYellowQty", 0);

		if (totemRedQty > 0)
			Events.OnGetItems ("totemRed", totemRedQty);
		if (totemBlueQty > 0)
			Events.OnGetItems ("totemBlue", totemBlueQty);
		if (totemYellowQty > 0)
			Events.OnGetItems ("totemYellow", totemYellowQty);

		//Invoke ("InventoryRefresh", 0.1f);
	}

	void InventoryRefresh()
	{
		//Events.InventoryRefresh ();
	}

	public void GetItem(string itemName)
	{
		Events.OnGetItem (itemName);
		Save (itemName, 1);
	}

	public void DestroyItem(string itemName)
	{
		Events.OnGetItem (itemName);
		Save (itemName, -1);
	}

	void Save(string itemName, int qty)
	{
		switch (itemName) {
		case "totemRed":
			totemRedQty += qty;
			if (totemRedQty < 0)
				return;
			PlayerPrefs.SetInt ("totemRedQty", totemRedQty);
			break;
		case "totemBlue":
			totemBlueQty += qty;
			if (totemBlueQty < 0)
				return;
			PlayerPrefs.SetInt ("totemBlueQty", totemBlueQty);
			break;
		case "totemYellow":
			totemYellowQty += qty;
			if (totemYellowQty < 0)
				return;
			PlayerPrefs.SetInt ("totemYellowQty", totemYellowQty);
			break;
		}
		Events.InventoryRefresh ();
	}
}