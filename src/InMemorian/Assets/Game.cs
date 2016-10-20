using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour {

    static Game mInstance = null;

    public static Game Instance
    {
        get
        {
            if (mInstance == null)
            {
                Debug.LogError("Algo llama a DATA antes de inicializarse");
            }
            return mInstance;
        }
    }

    void Awake()
    {
        if (!mInstance)
        {
            mInstance = this;
        }
        else
        {
            Destroy(this.gameObject);
            return;
        }

        PlayerPrefs.DeleteAll();
        DontDestroyOnLoad(this);
    }
}
