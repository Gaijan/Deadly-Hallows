using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class key : MonoBehaviour {
    [SerializeField]
    private Text PickUpText;

    private bool pickUpAllowed;
	// Use this for initialization
	void Start () {
        PickUpText.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
        if (pickUpAllowed && Input.GetButton("Fire2")) 
        PickUp();
	}


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("main static")) {
            PickUpText.gameObject.SetActive(true);
            pickUpAllowed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name.Equals("main static"))
        {
            PickUpText.gameObject.SetActive(false);
            pickUpAllowed = false;
        }
    }

    private void PickUp() {
        Destroy(gameObject);
    }
}
