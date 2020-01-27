using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerVideo : MonoBehaviour {
    public GameObject videoplayer;
    public int timeToStop;
	// Use this for initialization
	void Start () {
        videoplayer.SetActive(false);
	}
    private void OnTriggerEnter(Collider player)
    {
        if (player.gameObject.tag == "Player") {
            videoplayer.SetActive(true);
            Destroy(videoplayer, timeToStop);
        }
        
    }


}
