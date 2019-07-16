using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Controll : MonoBehaviour
{
    public GameManager gameManager;

    public bool isTaken;
    private void Start()
    {
        isTaken = false;
    }
    void Update()
    {
        if (Bird.isLocked && !isTaken)
        {
            gameManager.WinLevel();
            isTaken = true;
        }
    }
}
