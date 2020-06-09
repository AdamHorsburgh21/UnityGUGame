using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeDoor : MonoBehaviour
{
    public string TargetScene;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            SceneManager.LoadScene(TargetScene);
        }
    }
    //when the Charater's hitbox collides with the hitbox of the other object with the script and the tag 'Player' it will progress to the targeted scene
    //The next scene is targeted by writing the name of tthe scene in the component section of the object
}
