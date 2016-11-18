using UnityEngine;
using System.Collections;

public class RomRotateByCorners : MonoBehaviour {

    public Transform pivot;
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
            print("Front");
        else if (character.transform.position.z < -8)
            print("Back");

        StartCoroutine(Rotation());
    }
    IEnumerator Rotation()
    {
        int a = 0;
        Vector3 rot = pivot.localEulerAngles;
        while(a<90)
        {
            rot.x = -a;
            pivot.localEulerAngles = rot;           
            a++;
            yield return new WaitForEndOfFrame();
        }
        yield return null;
    }
}
