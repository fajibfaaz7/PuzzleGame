using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level2Controll : MonoBehaviour
{
    public GameManager gameManager;
    public bool isTaken;
    void Start()
    {
        isTaken = false;
    }

    
    void Update()
    {
        if (Bird.isLocked && Elephant.isLocked && !isTaken)
        {
            gameManager.WinLevel();
            isTaken = true;
        }
    }
}
