using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenetransition : MonoBehaviour {
    public Animator transitionAnim;
    public string sceneName;
	// Update is called once per frame
	void Update () {
        if (Input.GetButton("Interact")) {
            SceneManager.LoadScene(sceneName);
            StartCoroutine(LoadScene());
        }

	}
    IEnumerator LoadScene() {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneName);
    }
}
