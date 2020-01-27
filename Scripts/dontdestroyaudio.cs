using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dontdestroyaudio : MonoBehaviour {
    private static dontdestroyaudio instance;
    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else {
            instance = this;
        }
        DontDestroyOnLoad(transform.gameObject);
    }
}
