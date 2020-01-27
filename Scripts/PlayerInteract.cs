using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{

    public GameObject currentInterObj= null;
    public interactionObject currentInterObjectScript = null;
    public Inventory inventory;
  

    private void Update()
    {
        if (Input.GetButtonDown("Interact") && currentInterObj)
        {
            //check to see if this object is to be stored in inventory
            if (currentInterObjectScript.inventory)
            {
                inventory.AddItem(currentInterObj);
            }
            //check to see if this object is open
            if (currentInterObjectScript.openable)
            {
                //check to see if this objec tis locked
                if (currentInterObjectScript.locked)
                {
                    //check to see if we have the object needed t unlock
                    //search our inventory for the item needed - if found unlock Object
                    if (inventory.FindItem(currentInterObjectScript.ItemNeeded))
                    {
                        //we foun the item needed 
                        currentInterObjectScript.locked = false;
                        Debug.Log(currentInterObj.name + "was unlocked");
                    }
                    else
                    {
                        Debug.Log(currentInterObj.name + "was not unlocked");
                    }

                }
                else
                {
                    //object is not locked - open the object
                    Debug.Log(currentInterObj.name + "is unlocked ");
                    currentInterObjectScript.gameObject.SetActive(false);
               
                }
                

            }
    
           

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {

            
            Debug.Log(other.name);
            currentInterObj = other.gameObject;
            currentInterObjectScript = currentInterObj.GetComponent <interactionObject> ();
        }


    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("interObject"))
        {
            if (other.gameObject == currentInterObj) {
                
                currentInterObj = null;
            }
        }
    }
}
   
