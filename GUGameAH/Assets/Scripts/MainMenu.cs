using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Activates the play button - when clicked the button attached will load the next scene, continuing and starting the game.
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //adds the ability to close the application from a quit button on the main menu.
    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}