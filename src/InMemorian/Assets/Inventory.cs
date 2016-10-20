using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {

	public List<Item> items;

	void Start()
	{
		Events.OnGetItems += OnGetItems;
		Events.OnGetItem += OnGetItem;
		Events.OnDestroyItem += OnDestroyItem;
	}
	void OnGetItems(string itemName, int qty)
	{
		print("OnGetItems " + itemName + " qty: " + qty);
		for (int a = 0; a < qty; a++)
			OnGetItem(itemName);
	}
	void OnGetItem(string itemName)
	{
		Item item;
		if(ItemExists(itemName))
		{
			item = GetItemByName(itemName);
			item.qty++;
			return;
		}
		item = new Item();
		item.itemName = itemName;
		items.Add(item);

	}
	void OnDestroyItem(string itemName)
	{
		if (!ItemExists(itemName)) return;
		Item item = GetItemByName(itemName);
		if (item.qty > 1) 
			item.qty--;
		else
			items.Remove(item);
	}
	public bool ItemExists(string itemName)
	{
		foreach(Item item in items)
			if (item.itemName == itemName)
				return true;
		return false;
	}
	public Item GetItemByName(string itemName)
	{
		foreach (Item item in items)
			if (itemName == item.itemName)
				return item;
		return null;
	}
}
