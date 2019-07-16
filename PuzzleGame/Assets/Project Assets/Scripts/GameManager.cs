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
    public GameObject particle;
    public AudioManager audioManager;
    public GameObject pauseButton;
    public int nextLevel;
    public GameObject winCanvas;

    void Start()
    {
        
        time = 0f;
        star1.SetActive(false);
        star2.SetActive(false);
        star3.SetActive(false);
        particle.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void WinLevel()
    {
        
        Debug.Log("Won");
        PlayerPrefs.SetInt("levelReached", nextLevel);
        winCanvas.SetActive(true);
        pauseButton.SetActive(false);
        isStopped = true;
        if (time <= 100)
        {
            audioManager.Play("3Star");
            star1.SetActive(true);
            StartCoroutine(Star2());
            StartCoroutine(Star3());
            particle.SetActive(true);
            
        }
        else if(time>100 && time <= 300)
        {
            audioManager.Play("2Star");
            star1.SetActive(true);
            StartCoroutine(Star2());
        }
        else
        {
            audioManager.Play("1Star");
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
