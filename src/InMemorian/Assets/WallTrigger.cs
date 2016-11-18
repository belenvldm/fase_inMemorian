using UnityEngine;
using System.Collections;

public class WallTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.GetComponent<Character>())
            Events.OnWallTrigger( other.transform.GetComponent<Character>() );           
    }
}
