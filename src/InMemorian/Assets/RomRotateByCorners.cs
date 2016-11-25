using UnityEngine;
using System.Collections;

public class RomRotateByCorners : MonoBehaviour {

    public Transform pivot;
	//private Character characterDir;

	void Start ()
    {
        Events.OnWallTrigger += OnWallTrigger;
    }
	
    void OnDestroy()
    {
        Events.OnWallTrigger -= OnWallTrigger;
    }
	
    void OnWallTrigger(Character character)
    {
        if (character.transform.position.z > 8)
		{
			StartCoroutine(Rotation(1, character));
			//StartCoroutine(CharacterTranslation(1, character));
		} else if (character.transform.position.z < -8)	{
			StartCoroutine(Rotation(-1, character));
			//StartCoroutine(CharacterTranslation(-1, character));
		}			
    }
	float finalRotation;
	IEnumerator Rotation(int dir, Character character)
    {
		Vector3 rot = pivot.rotation.eulerAngles;

		float lastCharacterPos = dir * -(character.MAX_DISTANCE-2) * 2;
		Vector3 charPos = character.transform.localPosition;
		int a = 0;

		int initialRot = (int)pivot.rotation.eulerAngles.x;

		print (initialRot);


		//pivot.rotation = Quaternion.Euler (initialRot, 0, 0);

		if(dir==1)
		{
		if (initialRot == 0)
			finalRotation = 270;
		else if (initialRot == 270)
			finalRotation = 180;
		else if (initialRot == 180)
			finalRotation = 90;
		else if (initialRot == 90)
			finalRotation = 0;
		} else
		{
			if (initialRot == 0)
				finalRotation = 90;
			else if (initialRot == 270)
				finalRotation = 0;
			else if (initialRot == 180)
				finalRotation = 270;
			else if (initialRot == 90)
				finalRotation = 180;
		}
		
		print (initialRot + " dir: " + dir + " finalRotation:_ " + finalRotation);

		while (a <= 90) {			
			rot.x = -a*dir;
			rot.x += initialRot;

			//print (rot.x);

			pivot.rotation = Quaternion.Euler (rot.x, 0, 0);
			float newPosZ =  (dir * (float)character.MAX_DISTANCE) + (a * lastCharacterPos / 90);



			if (a < 45)
				charPos.y += 1* 0.1f;
			else
				charPos.y -= 1* 0.1f;
			
			charPos.z = newPosZ;

			character.transform.localPosition = charPos;
			a++;
			yield return new WaitForEndOfFrame ();
		}
		charPos.y  =0;
		character.transform.localPosition = charPos;
		//pivot.rotation = Quaternion.Euler (finalRotation, 0, 0);

		yield return null;
	}


}