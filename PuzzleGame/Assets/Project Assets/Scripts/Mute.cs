using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mute : MonoBehaviour
{
    public static bool isMuted;
    
    void Start()
    {
        
        isMuted = false;
    }

    
    public void Toggle()
    {
        if (!isMuted)
        {
            AudioListener.pause = true;
            isMuted=true;
            PlayerPrefs.SetFloat("music", 0);
        }
        else
        {
            AudioListener.pause = false;
            isMuted = false;
            PlayerPrefs.SetFloat("music", 1);
        }
    }
}
