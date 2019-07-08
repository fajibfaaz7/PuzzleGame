using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Controll : MonoBehaviour
{
    public GameManager gameManager;
  
    void Update()
    {
        if (Bird.isLocked)
        {
            gameManager.WinLevel();
        }
    }
}
