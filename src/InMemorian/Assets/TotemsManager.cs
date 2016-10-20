using UnityEngine;
using System.Collections;

public class TotemsManager : MonoBehaviour {

	public Transform[] totemsPlaceHolder;
	public ItemPickUp[] totems;

	// Use this for initialization
	void Start () {
		int id = 0;
		Shuffle (totemsPlaceHolder);
		foreach(Transform tr in totemsPlaceHolder)
		{
			ItemPickUp totem = Instantiate (totems [id]);
			totem.transform.localPosition = tr.transform.localPosition;
			tr.GetComponent<MeshRenderer> ().enabled = false;
			totem.Init (GetComponent<Game>());
			id++;
		}
	}
	
	private void Shuffle(Transform[] tr)
	{
		for (int a = 0; a < 100; a++) 
		{
			int positionArr = Random.Range (1, tr.Length);
			Transform randomItem = tr [positionArr];
			Transform firstItem = tr [0];
			tr [0] = randomItem;
			tr [positionArr] = firstItem;
		}
	}
}
