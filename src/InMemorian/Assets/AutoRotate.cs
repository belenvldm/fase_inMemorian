using UnityEngine;
using System.Collections;

public class AutoRotate : MonoBehaviour {

    public int acceleration;
    float _y = 0;

    void Update () {
        _y += Time.deltaTime * acceleration;
        transform.localEulerAngles = new Vector3(0, _y, 0);
	}
}
