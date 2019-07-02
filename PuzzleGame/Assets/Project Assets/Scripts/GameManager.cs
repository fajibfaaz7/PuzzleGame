using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject[] sprites;
    public GameObject[] spritesOcc;
    public int spLength;
    public int nextLevel;
    public string nextLevelName;
    public int count;
    


    
    public SceneFader sceneFader;

    private void Start()
    {
        spLength = sprites.Length;
    }

    void Update()
    {
        for (int i = 0, j = 0; i < spLength && j < spLength; i++, j++)
        {
            if(sprites[i].transform.position == spritesOcc[j].transform.position)
            {
                  
            }
        }

        
    }

   
    public void WinLevel()
    {
        Debug.Log("Won");
        //PlayerPrefs.SetInt("levelReached", nextLevel);
        //sceneFader.FadeTo(nextLevelName);
    }
}
