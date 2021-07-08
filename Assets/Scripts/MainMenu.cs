using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //If the play button get's pressed go to next scene
    public void Playgame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //If the quit button get's pressed quit the game
    public void Quitgame ()
    {
        Application.Quit();
    }
}
