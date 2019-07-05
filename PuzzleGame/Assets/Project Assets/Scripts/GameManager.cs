using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int nextLevel;
    //public string nextLevelName;
    //public int count;
    public GameObject winCanvas;
    
 
    public void WinLevel()
    {
        Debug.Log("Won");
        PlayerPrefs.SetInt("levelReached", nextLevel);
        winCanvas.SetActive(true);
    }
}
