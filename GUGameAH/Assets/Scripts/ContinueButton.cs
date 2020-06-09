using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ContinueButton : MonoBehaviour
{
    public void Continue()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    //Uses Unity's Scene MAnagement and calls to load the next scene in the build index

    public void Main_Menu()
    {
        SceneManager.LoadScene("Start_Menu");
    }
    //Calls the scene manager to load the main menu of the game - used on the button on the final scene in the build index to go to the first scene
}
