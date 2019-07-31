using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioCheck : MonoBehaviour
{
    public float musicState;
    



    void Update()
    {
        musicState = PlayerPrefs.GetFloat("music", 1);
        if (musicState == 0)
        {
            gameObject.GetComponent<Toggle>().isOn = true;
        }
        else
        {
            gameObject.GetComponent<Toggle>().isOn = false;
        }
    }
}
