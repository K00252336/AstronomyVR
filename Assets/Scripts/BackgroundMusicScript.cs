using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusicScript : MonoBehaviour
{
    //AudioSource-BackgroundMusic has to be in Main Heirarchy to create "DontDestroyOnLoad"
    public static BackgroundMusicScript instance;

    private void Awake()
    {
        if (instance == null)
        {
            DontDestroyOnLoad(this.gameObject);
            instance = this; //Prevents duplication of background music
        }
        else
        {
            Destroy(gameObject);//Destroys duplicate
        }
    }
}