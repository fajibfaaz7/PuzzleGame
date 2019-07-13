using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time = 0;
    public GameObject star1;
    public GameObject star2;
    public GameObject star3;
    public bool isStopped;

    public int nextLevel;
    //public string nextLevelName;
    //public int count;
    public GameObject winCanvas;

    void Start()
    {
        time = 0f;
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
    }

    public void WinLevel()
    {
        Debug.Log("Won");
        PlayerPrefs.SetInt("levelReached", nextLevel);
        winCanvas.SetActive(true);
        isStopped = true;
        if (time <= 100)
        {
            star1.SetActive(true);
            StartCoroutine(Star2());
            StartCoroutine(Star3());
        }
        else if(time>100 && time <= 300)
        {
            star1.SetActive(true);
            StartCoroutine(Star2());
        }
        else
        {
            star1.SetActive(true);
        }
    }
    private void Update()
    {
        if (!isStopped)
        {
            time += Time.deltaTime;
        } 
        Debug.Log(time);
    }

    IEnumerator Star2()
    {
        yield return new WaitForSeconds(.5f);
        star3.SetActive(true);
    }
    IEnumerator Star3()
    {
        yield return new WaitForSeconds(.9f);
        star2.SetActive(true);
    }
}
