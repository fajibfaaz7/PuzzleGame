using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{

    public GameObject pauseUi;
    public GameObject pauseButton;
    public void Toggle()
    {
        pauseUi.SetActive(!pauseUi.activeSelf);
        pauseButton.SetActive(!pauseButton.activeSelf);
        if (pauseUi.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
