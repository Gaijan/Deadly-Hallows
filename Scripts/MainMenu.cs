using System.Collections;
using System.Collections.Generic;
using UnityEngine.PSVita;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    public void PlayButton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void ControlButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void Backbutton() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 9);
    }

    public void Homebutton() {
        SceneManager.LoadScene(0);
    }
    public void QuitButton() {
        Application.Quit();
    }
    public void Endbutton()
    {
        SceneManager.LoadScene(10);
    }
}
