using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class level4Controll : MonoBehaviour
{
    public GameManager gameManager;
    void Start()
    {

    }


    void Update()
    {
        if (Bird.isLocked && Elephant.isLocked && Giraffe.isLocked && Lion.isLocked)
        {
            gameManager.WinLevel();
        }
    }
}
