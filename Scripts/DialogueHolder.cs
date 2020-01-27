using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueHolder : MonoBehaviour {
    public string dialogue;
    private DialogueManager dMan;

    public string[] dialogLines;
	// Use this for initialization
	void Start () {
        dMan = FindObjectOfType<DialogueManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.name=="main static") {
            if (Input.GetButtonUp("Fire1")) {
                //dMan.ShowBox(dialogue);

                if (!dMan.dialogActive) {
                    dMan.dialogLines = dialogLines;
                    dMan.currentLine = 0;
                    dMan.ShowDialogue();
                }
            }
        }
        
    }
}
