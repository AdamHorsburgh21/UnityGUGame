using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    void Awake()
    {
        //Upon opening the game, the imported music asset will begin playing.
        GameObject[] objs = GameObject.FindGameObjectsWithTag("music");

        //The track is set to loop but we do not want the sound to overlap so once it has completed a cycle it is destroyed and can play again from the loop.
        if (objs.Length > 1)
            Destroy(this.gameObject);

        //This allows the music to play after changing scene
        DontDestroyOnLoad(this.gameObject);
    }
 
}