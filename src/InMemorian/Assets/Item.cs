using UnityEngine;
using System.Collections;
using System;

[Serializable]
public class Item
{
	public string itemName;
	public int qty = 1;
	public string description;
	public Texture2D texture;
	public bool used;
}