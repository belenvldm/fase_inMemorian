using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FadeToBlack : MonoBehaviour {

	public Canvas canvas;
	private FadeData fadeData;
	public Image image;

	void Start () {
		DontDestroyOnLoad (this);
		Events.Fade += Fade;
		canvas.enabled = false;
	}

	void Fade(FadeData fadeData)
	{
		this.fadeData = fadeData;
		StartCoroutine (DoFade ());
	}

	IEnumerator DoFade()
	{
		canvas.enabled = true;
		print ("Arranca coroutine");
		Color color = fadeData.color;
		float num = 0;
		while (num < fadeData.duration) 
		{
			num += Time.deltaTime;
			DoTransition (num);
			yield return new WaitForEndOfFrame ();
		}
        Events.FadeReady();
		while (num > 0) 
		{
			num -= Time.deltaTime;
			DoTransition (num);
			yield return new WaitForEndOfFrame ();
		}
		// Destroy (gameObject);
		print ("Arranca coroutine");
		yield return null;
	}

	void DoTransition(float num)
	{
		fadeData.color.a = num;
		image.color = fadeData.color;
	}

}
