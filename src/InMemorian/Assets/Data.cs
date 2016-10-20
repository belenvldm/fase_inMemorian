using UnityEngine;
using System.Collections;

public class Data : MonoBehaviour {

	static Data mInstance = null;

	public static Data Instance
	{
		get
		{
			if (mInstance == null) {
				Debug.LogError ("Algo llama a DATA antes de inicializarse");
			}
			return mInstance;
		}
	}

	void Awake()
	{
		if (!mInstance) {
			mInstance = this;
		} else {
			Destroy (this.gameObject);
			return;
		}

		PlayerPrefs.DeleteAll ();
		DontDestroyOnLoad (this);
	}
}