using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interactionObject : MonoBehaviour {

    public bool inventory; //If true this Object can be stored in inventory
    public bool openable; // If true this object can be opened
    public bool locked; //If true this object is locked
    public GameObject ItemNeeded; //Item needed in order to interact with this item

 
    public void DoInteraction() {
        //Picked up and put inventory
        gameObject.SetActive(false);
    }

   
}
