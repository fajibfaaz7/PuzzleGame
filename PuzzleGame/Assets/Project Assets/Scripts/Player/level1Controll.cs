using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level1Controll : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Bird.isLocked)
        {
            gameManager.WinLevel();
        }
    }
}
