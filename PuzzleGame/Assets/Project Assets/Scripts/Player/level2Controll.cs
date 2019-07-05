using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Controll : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    
    void Update()
    {
        if (Bird.isLocked && Elephant.isLocked)
        {
            gameManager.WinLevel();
        }
    }
}
